using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
   private Dictionary<QuestSO,Dictionary<QuestObjective,int>> questProgress=new();
    public InventoryManager inventoryManager;
    public DialogueHistoryTracker dialogueHistoryTracker;
    private List<QuestSO> completeQuests = new();

    private void OnEnable()
    {
        QuestEvents.IsQuestCompleted += IsQuestCompleted;
    }
    private void OnDisable()
    {
        QuestEvents.IsQuestCompleted -= IsQuestCompleted;
    }

    public bool IsQuestCompleted(QuestSO questSO)
    {
        if (!questProgress.TryGetValue(questSO, out var progressDict))
        {
            return false;
        }
        foreach (var objective in questSO.objectives)
        {
            UpdateObjectiveUI(questSO, objective);
        }
        foreach (var objective in questSO.objectives)
        {
            if (progressDict[objective]<objective.reguiredAmount)
            {
                return false;
            }
        }
        return true;
    }

    #region Quest Accept Logic
    public bool IsQuestAccept(QuestSO questSO)
    {
        return questProgress.ContainsKey(questSO);
    }
    public List<QuestSO> GetActiveQuests()
    {
        return new List<QuestSO>(questProgress.Keys);
    }

   
    public void AcceptQuest(QuestSO questSO)
    {
        questProgress[questSO] = new Dictionary<QuestObjective, int>();
        foreach (var questObject in questSO.objectives)
        {
            UpdateObjectiveUI(questSO,questObject);
        }
    }
    #endregion



    public void UpdateObjectiveUI(QuestSO questSO,QuestObjective questObjective)
    {
        if (!questProgress.ContainsKey(questSO))
            return;
        var progressDictionary = questProgress[questSO];
        int newAmount=0;

        if (questObjective.targetItem != null)
        {
            newAmount = inventoryManager.GetItemQuantity(questObjective.targetItem); 
        }
        else if(questObjective.targetNPC!=null&&dialogueHistoryTracker.HasSpokenWith(questObjective.targetNPC))
        {
            newAmount = questObjective.reguiredAmount;
        }
        progressDictionary[questObjective] = newAmount;

    }
    public void CompleteQuest(QuestSO questSO)
    {
        questProgress.Remove(questSO);
        completeQuests.Add(questSO);
        foreach (var reward in questSO.rewards)
        {
            inventoryManager.AddItem(reward.item, reward.quantity);
        }
    }
    public bool GetCompleteQuest(QuestSO questSO)
    {
        return completeQuests.Contains(questSO);
    }

    public string GetProgressText(QuestSO questSO, QuestObjective questObjective)
   {
        int currentAmount = GetCurrentAmount(questSO,questObjective);
        if (currentAmount >= questObjective.reguiredAmount)
            return "Complete";
        else if (questObjective.targetItem != null)
            return $"{currentAmount}/{questObjective.reguiredAmount}";
        else
            return "In progress";

   }
    public int GetCurrentAmount(QuestSO questSO, QuestObjective questObjective)
    {
        if (questProgress.TryGetValue(questSO, out var objectiveDictionary))
            if (objectiveDictionary.TryGetValue(questObjective, out int amount))
                return amount;
        return 0;
    }
}

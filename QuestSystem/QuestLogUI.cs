using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestLogUI : MonoBehaviour
{
    [SerializeField] private QuestManager questManager;

    [SerializeField] private TMP_Text questName;
    [SerializeField] private TMP_Text questDescription;
    [SerializeField] private QuestObjectiveSlot[] objectiveSlots;
    [SerializeField] private QuestRewardsSlot[] questRewardsSlots;

    [SerializeField] private CanvasGroup acceptCanvasGropu;
    [SerializeField] private CanvasGroup declineCanvasGropu;
    [SerializeField] private CanvasGroup completeCanvasGropu;
    

    private QuestSO questSO;

    [SerializeField] QuestSO NoAvailableQuests;

    [SerializeField] private QuestLogSlot[] questLogSlots;

    [SerializeField] private CanvasGroup questCanvas;

    private void OnEnable()
    {
        QuestEvents.OnQuestOfferRequested += showQuestOff;
        QuestEvents.OnQuestTurnInRequested += showQuestTurnIn;
    }
    private void OnDisable()
    {
        QuestEvents.OnQuestOfferRequested -= showQuestOff;
        QuestEvents.OnQuestTurnInRequested -= showQuestTurnIn;

    }

    public void showQuestOff(QuestSO incomingQuest)
    {
        if (questManager.IsQuestAccept(incomingQuest)||questManager.GetCompleteQuest(incomingQuest))
        {
            questSO = NoAvailableQuests;
            setCanvasState(acceptCanvasGropu, false);
            setCanvasState(declineCanvasGropu, true);
            setCanvasState(completeCanvasGropu, false);
        }
        else
        {
            questSO = incomingQuest;
            setCanvasState(acceptCanvasGropu, true);
            setCanvasState(declineCanvasGropu, true);
            setCanvasState(completeCanvasGropu, false);
        }
        HandleQuestClik(questSO);
        setCanvasState(questCanvas, true);   
    }
    public void showQuestTurnIn(QuestSO incomingQuestSO)
    {
        questSO = incomingQuestSO;
        HandleQuestClik(questSO);
        setCanvasState(completeCanvasGropu, true);
        setCanvasState(acceptCanvasGropu, false);
        setCanvasState(declineCanvasGropu, false);
        setCanvasState(questCanvas, true);
    }

    public void setCanvasState(CanvasGroup group,bool activate)
    {
        group.alpha = activate ? 1 : 0;
        group.blocksRaycasts = activate;
        group.interactable = activate;
    }

    public void OnAcceptQuestClinked()
    {
        questManager.AcceptQuest(questSO);
        setCanvasState(completeCanvasGropu, false);
        setCanvasState(acceptCanvasGropu, false);
        setCanvasState(declineCanvasGropu, false);
        RefreshQuestClicked();
        HandleQuestClik(NoAvailableQuests);
    }

    public void OnDeclineQuestCliked()
    {
        setCanvasState(questCanvas, false);
    }

    public void OnCompleteQuestClicked()
    {
        questManager.CompleteQuest(questSO);

        RefreshQuestClicked();
        HandleQuestClik(NoAvailableQuests);
        setCanvasState(completeCanvasGropu,false);

        
    }

    public void RefreshQuestClicked()
    {
        List<QuestSO> activeQuests = questManager.GetActiveQuests();
        for (int i = 0; i < questLogSlots.Length; i++)
        {
            if (i<activeQuests.Count)
            {
                questLogSlots[i].SetQuest(activeQuests[i]);
            }
            else
            {
                questLogSlots[i].ClearSlot();
            }
        }
    }

    public void HandleQuestClik(QuestSO questSO)
    {
        this.questSO = questSO;

        questDescription.text = questSO.questDescription;
        questName.text = questSO.name;

        DisplayObjective();
        DisplayRewards();
    }

    private void DisplayObjective()
    {
        for (int i = 0; i < objectiveSlots.Length; i++)
        {
            if (i < questSO.objectives.Count)
            {
                var objective = questSO.objectives[i];
                questManager.UpdateObjectiveUI(questSO, objective);

                int currentAmount = questManager.GetCurrentAmount(questSO, objective);
                string progress = questManager.GetProgressText(questSO, objective);
                bool isComplete = currentAmount >= objective.reguiredAmount;

                objectiveSlots[i].gameObject.SetActive(true);
                objectiveSlots[i].RefreshObjective(objective.description, progress, isComplete);
            }
            else
            {
                objectiveSlots[i].gameObject.SetActive(false);
            }
        }
    }
    private void DisplayRewards()
    {
        for (int i = 0; i < questRewardsSlots.Length; i++)
        {
            if (i < questSO.rewards.Count)
            {
                var reward = questSO.rewards[i];
                questRewardsSlots[i].DisplayReward(reward.item.icon, reward.quantity);
                questRewardsSlots[i].gameObject.SetActive(true);
            }
            else
            {
                questRewardsSlots[i].gameObject.SetActive(false);
            }
        }
    }
}

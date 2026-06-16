using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="QuestSO",menuName ="QuestSO")]
public class QuestSO : ScriptableObject
{
    public string questName;
    [TextArea] public string questDescription;
    public int questLevel;

    public List<QuestObjective> objectives;
    public List<QuestReward> rewards;
}

[System.Serializable]
public class QuestObjective
{
    public string description;

    [SerializeField]private Object TargetItem;

    public ItemSO targetItem => TargetItem as ItemSO;
    public ActorSO targetNPC => TargetItem as ActorSO;

    public int reguiredAmount;
    
}

[System.Serializable]
public class QuestReward
{
    public ItemSO item;
    public int quantity;
}

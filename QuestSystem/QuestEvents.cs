using System;

public static class QuestEvents 
{
    public static Action<QuestSO> OnQuestOfferRequested;
    public static Func<QuestSO, bool> IsQuestCompleted;
    public static Action<QuestSO> OnQuestTurnInRequested;
}

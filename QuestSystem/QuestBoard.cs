using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestBoard : MonoBehaviour
{
    [SerializeField] private QuestSO questToOff;
    [SerializeField] private QuestSO questToTurnIn;
    private bool playerInRanger;
    void Update()
    {
        if (playerInRanger&&Input.GetButtonDown("Interact"))
        {
            bool canTurnIn = questToTurnIn != null && QuestEvents.IsQuestCompleted?.Invoke(questToTurnIn) == true;
            if (canTurnIn)
            {
                QuestEvents.OnQuestTurnInRequested?.Invoke(questToTurnIn);
            }
            else
            {
                QuestEvents.OnQuestOfferRequested?.Invoke(questToOff);
            }
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRanger = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRanger = false;
        }
    }
}

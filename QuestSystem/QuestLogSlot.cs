using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestLogSlot : MonoBehaviour
{
    [SerializeField] private TMP_Text questName;
    [SerializeField] private TMP_Text questLevelText;

    public QuestSO currentQuest;
    public QuestLogUI questUI;


    private void OnValidate()
    {
        if (currentQuest != null)
            SetQuest(currentQuest);
        else
            gameObject.SetActive(false);
    }

    public void SetQuest(QuestSO questSO)
    {
        currentQuest = questSO;


        questName.text = questSO.questName;
        questLevelText.text ="Lv. "+ questSO.questLevel.ToString();

        gameObject.SetActive(true);
    }

    public void ClearSlot()
    {
        currentQuest = null;
        gameObject.SetActive(false);

    }

    public void OnClick()
    {
        questUI.HandleQuestClik(currentQuest);
    }
}

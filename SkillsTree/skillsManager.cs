using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class skillsManager : MonoBehaviour
{
    
    public SkillSlot[] skillSlots;
    public TMP_Text pointsText;
    public int availablePoints;

    private void OnEnable()
    {
        SkillSlot.onAbilityPointSpent += HandleAbilityPointsSpent;
        SkillSlot.onSkillMaxed += HandleSkillMaxed;
        Expmanager.onLevelUp += UpdateAbilityPoints;
    } 
    private void OnDisable()
    {
        SkillSlot.onAbilityPointSpent -= HandleAbilityPointsSpent;
        SkillSlot.onSkillMaxed -= HandleSkillMaxed;
        Expmanager.onLevelUp -= UpdateAbilityPoints;

    }
    private void Start()
    {
        foreach (SkillSlot slot in skillSlots)
        {
            slot.skillButton.onClick.AddListener(()=>CheckAvailablePoints(slot));
        }
        UpdateAbilityPoints(0);

    }
    private void CheckAvailablePoints(SkillSlot slot)
    {
        if (availablePoints > 0)
        {
            slot.TryUpgradeSkill();
        }
    }
    public void UpdateAbilityPoints(int amounts)
    {
        availablePoints += amounts;
        pointsText.text = "Points: " + availablePoints;
    }

    private void HandleAbilityPointsSpent(SkillSlot skillSlot)
    {
        if (availablePoints > 0)
        {
            UpdateAbilityPoints(-1);

        }
    }
    private void HandleSkillMaxed(SkillSlot skillSlot)
    {
        foreach (SkillSlot slot in skillSlots)
        {
            if (!slot.isUnlocked && slot.CanUnlockSkill())
            {
            slot.Unlocked();

            }
        }
    }
}

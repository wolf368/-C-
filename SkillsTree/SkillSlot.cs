using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class SkillSlot : MonoBehaviour
{
    public SkillsSO skillSo;
    public List<SkillSlot> prerequisiteSkilSlots;

    public int currentLevel;
    public bool isUnlocked;
    public Button skillButton;

    public Image skillIcon;
    public TMP_Text skillLevleText;

    public static event Action<SkillSlot> onAbilityPointSpent;
    public static event Action<SkillSlot> onSkillMaxed;

    private void OnValidate()
    {
        if (skillSo != null && skillLevleText!= null)
        {
            UpdateUI();

        }
    }
    public void TryUpgradeSkill()
    {
        if (isUnlocked && currentLevel < skillSo.maxLevel)
        {
            currentLevel++;
            onAbilityPointSpent?.Invoke(this);

            if (currentLevel >= skillSo.maxLevel)
            {
                onSkillMaxed?.Invoke(this);

            }
            UpdateUI();
        }
    }
    public bool CanUnlockSkill()
    {
        foreach (SkillSlot slot in prerequisiteSkilSlots)
        {
            if (!slot.isUnlocked|| slot.currentLevel<slot.skillSo.maxLevel)
            {
                return false;
            }
        }
        return true;
    }
    public void Unlocked()
    {
        isUnlocked = true;
        UpdateUI();
    }
    private void UpdateUI()
    {
        skillIcon.sprite = skillSo.skillIcon;
        if (isUnlocked )
        {
            skillButton.interactable = true;
            skillLevleText.text = currentLevel.ToString() + "/" + skillSo.maxLevel.ToString();
            skillIcon.color = Color.white;
        }
        else
        {
            skillButton.interactable = false;
            skillLevleText.text = "Locked";
            skillIcon.color = Color.grey;
        }
    }
    
}

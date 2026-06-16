using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKillSet : MonoBehaviour
{
    public Player_Combat combat;

    private void OnEnable()
    {
        SkillSlot.onAbilityPointSpent += HandleAbilityPointSpent;
    }
    private void OnDisable()
    {
        SkillSlot.onAbilityPointSpent -= HandleAbilityPointSpent;

    }

    private void HandleAbilityPointSpent(SkillSlot slot)
    {
        string skillName = slot.skillSo.skillName;
        
        switch (skillName)
        {
            case "Max Health Boost":
                StatsManager.Instance.UpdateMaxHealth(1);
                break;
            case "Sword Slash":
                combat.enabled = true;
                break;

            default:
                Debug.Log("skills name wrong");
                break;

        }
    }
}

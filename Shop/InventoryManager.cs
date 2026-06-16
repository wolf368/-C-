using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InventoryManager : MonoBehaviour
{
    public InventorySlots[] itemSlots;
    public UseItem useItem;
    public int gold;
    public TMP_Text goldText;
    public GameObject lootPrefab;
    public Transform player;

    public static Action<int> OnExperienceGained;

    private void Start()
    {
        foreach (var slot in itemSlots)
        {
            slot.UpdateUI();
        }
    }
    private void OnEnable()
    {
        Loot.OnItemLooted += AddItem;
    }
    private void OnDisable()
    {
        Loot.OnItemLooted -= AddItem;
    }
    public void AddItem(ItemSO itemSO, int quantity)
    {
        //是否为金币
        if (itemSO.isGold)
        {
            gold += quantity;
            goldText.text = gold.ToString();
            return;
        }
        if (itemSO.isEXP)
        {
            OnExperienceGained?.Invoke(quantity);
        }
        //是否有相同的槽位
        foreach (var slot in itemSlots)
        {
            if (slot.itemSO == itemSO && slot.quantity < itemSO.stackSize)
            {
                int availableSpace = itemSO.stackSize - slot.quantity;
                int amountToAdd = Mathf.Min(availableSpace, quantity);

                slot.quantity += amountToAdd;
                quantity -= amountToAdd;

                slot.UpdateUI();

                if (quantity <= 0)
                {
                    return;
                }
            }
        }
        //检查空槽位
        foreach (var slot in itemSlots)
        {
            if (slot.itemSO == null)
            {
                int amountToAdd = Mathf.Min(itemSO.stackSize, quantity);

                slot.itemSO = itemSO;
                slot.quantity = quantity;
                slot.UpdateUI();
                return;

            }
        }

        if (quantity>0)
        {
            DropLoot(itemSO, quantity);
        }
    }

    public void DropItem(InventorySlots slots)
    {
        DropLoot(slots.itemSO, 1);
        slots.quantity--;
        if (slots.quantity <= 0)
        {
            slots.itemSO = null;
        }
        slots.UpdateUI();
    }
    private void DropLoot(ItemSO itemSO, int quantity)
    {
        Loot loot = Instantiate(lootPrefab, player.position, Quaternion.identity).GetComponent<Loot>();
        loot.Initialize(itemSO, quantity);
    }

    public void UseItem(InventorySlots slot)
    {
        if (slot.itemSO != null && slot.quantity >= 0)
        {
            useItem.ApplyItemEffects(slot.itemSO);
            slot.quantity--;
            if (slot.quantity <= 0)
            {
                slot.itemSO = null;
            }
            slot.UpdateUI();
        }
    }

    public int GetItemQuantity(ItemSO item)
    {
        int total = 0;
        foreach (var slot in itemSlots)
        {
            if (slot.itemSO = item)
            {
                total += slot.quantity;
            }
        }
        return total;
    }

}



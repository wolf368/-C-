using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item")]
public class ItemSO : ScriptableObject
{
    // Start is called before the first frame update
    public string itemName;
    [TextArea] public string itemDescription;
    public Sprite icon;

    public bool isGold;
    public bool isEXP;
    public int stackSize=8;

    [Header("Stats")]
    public int currentHealth;
    public int maxHealth;
    public int speed;
    public int damage;

    [Header("For Temporary Item")]
    public float duration;
}

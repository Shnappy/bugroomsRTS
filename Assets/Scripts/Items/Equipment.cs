using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment Object",menuName = "Inventory System/Items/Equipment")]
public class Equipment : Item
{
    public float damageModifier;
    public float defenceModifier;
    public float moveSpeedModifier;
    public void Awake()
    {
        type = ItemType.Equipment;
    }
}

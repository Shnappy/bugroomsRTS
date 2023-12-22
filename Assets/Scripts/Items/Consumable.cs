using UnityEngine;
[CreateAssetMenu(fileName = "Consumable Object",menuName = "Inventory System/Items/Consumable")]
public class Consumable : Item
{
    public int restoreHealthValue;
    public void Awake()
    {
        type = ItemType.Consumable;
    }
}

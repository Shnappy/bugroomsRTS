using UnityEngine;

[CreateAssetMenu(fileName = "Tool Object",menuName = "Inventory System/Items/Tool")]
public class Tool : Item
{
    public void Awake()
    {
        type = ItemType.Tool;
    }
}

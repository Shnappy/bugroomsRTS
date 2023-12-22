using UnityEngine;

public enum ItemType
{
    Equipment,
    Tool,
    Weapon,
    Consumable,
    Resource
}
public abstract class Item : ScriptableObject
{
    public GameObject prefab;
    public ItemType type;
    [TextArea(15, 20)] public string description;
}

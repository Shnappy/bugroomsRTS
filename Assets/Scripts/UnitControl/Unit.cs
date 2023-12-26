using System;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public Inventory inventory;
    void Start()
    {
        UnitSelections.Instance.unitList.Add(this.gameObject);
    }

    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<ItemObject>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }
    }
    private void OnDestroy()
    {
        UnitSelections.Instance.unitList.Remove(this.gameObject);
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}

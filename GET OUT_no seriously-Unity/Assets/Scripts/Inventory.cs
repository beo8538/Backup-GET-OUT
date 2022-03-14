using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    /**Another version on making a singleton**/
    public static Inventory instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory is found");
            return;
        }
        instance = this;
    } //singleton over

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 5; //space in inventory

    public List<InventoryItemData> items = new List<InventoryItemData>();

    public bool  Add (InventoryItemData item)
    {
        if(items.Count >= space)
        {
            Debug.Log("Not enough room");
            return false;
        }
        items.Add(item);

        if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke();

        return true;
    }


    public void Remove(InventoryItemData item)
    {
        items.Remove(item);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }

}
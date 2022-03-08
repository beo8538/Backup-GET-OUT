/**** 
 * Created by: Betzaida Ortiz Rivas
 * Date Created: March 7, 2022
 * 
 * Last Edited by: NA
 * Last Edited:
 * 
 * Description: Actual inventory system
****/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{

    //grab item stack easy with ref data with dictionary
    private Dictionary<InventoryItemData, InventoryItem> m_itemDictionary;
    internal static object current;

    public List<InventoryItem> inventory { get; private set; }

    private void Awake()
    {
        inventory = new List<InventoryItem>();
        m_itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
    }

    public InventoryItem Get(InventoryItemData referenceData)
    {
        if(m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            return value;
        }
        return null;
    }

    public void Add(InventoryItemData referenceData) //adding to inventory method
    {
        if(m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.AddToStack();
        }
        else
        {
            InventoryItem newItem = new InventoryItem(referenceData);
            inventory.Add(newItem);
            m_itemDictionary.Add(referenceData, newItem);
        }
    }

    /**inverese of adding, removing item from inventory**/
    public void Remove(InventoryItemData referenceData)
    {
        if(m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.RemoveFromStack();

            if(value.stackSize == 0)
            {
                inventory.Remove(value);
                m_itemDictionary.Remove(referenceData);
            }
        }
    }

    [Serializable]
    public class InventoryItem
    {
        public InventoryItemData data { get; private set; } //references data (items)
        public int stackSize { get; private set; }

        //Constructor where data passess and sets
        public InventoryItem(InventoryItemData source)
        {
            data = source;
            AddToStack();
        }
        //add items to inventory
        public void AddToStack()
        {
            stackSize++;
        }
        //remove items from inventory
        public void RemoveFromStack()
        {
            stackSize--;
        }
    }
}

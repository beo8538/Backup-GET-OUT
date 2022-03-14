using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent; //ref the children in slots

    Inventory inventory;

    InventorySlot[] slots; //array of items in inventory slots

    // Start is called before the first frame update
    //initialize things here
    void Start()
    {
        inventory = Inventory.instance; //calls back to singleton
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>(); //gets all the componets of children
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    //Updates the UI on Inventory
    void UpdateUI()
    {
        Debug.Log("Updating UI");

        //for loop to loop through all slots
        for(int i = 0; i < slots.Length; i++)
        {
            //if there are more items to add
            if( i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            //if we don't have anymore items or enough items to add
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}

/**** 
 * Created by: Betzaida Ortiz Rivas
 * Date Created: March 7, 2022
 * 
 * Last Edited by: NA
 * Last Edited:
 * 
 * Description: pick up items
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable
{

    public ItemPickup item;

    public override void Interact()
    {
        base.Interact();
    }

    public void PickUp()
    {
       Debug.Log("Picked up " + item.name);
        //Add item to inventory

        //Destroy item
        Destroy(gameObject);
    }



}


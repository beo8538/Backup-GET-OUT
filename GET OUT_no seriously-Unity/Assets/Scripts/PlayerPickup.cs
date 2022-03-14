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

public class PlayerPickup : MonoBehaviour
{
    [SerializeField] private float pickupRange;
    [SerializeField] private LayerMask pickUpLayer;

    public InventoryItemData item;

    private Camera cam;

    private void Start()
    {
        GetReferences();
    }

    public void Update()
    {
        //Add item to inventory
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;

            //Raycast
            if (Physics.Raycast(ray, out hit, pickupRange, pickUpLayer))
            {
                Debug.Log("Hit: " + hit.transform.name);
               bool wasPickedUp = Inventory.instance.Add(item);

                if (wasPickedUp)
                    Destroy(gameObject);
            }
        }
    }

    private void GetReferences()
    {
        cam = GetComponentInChildren<Camera>();
    }



}


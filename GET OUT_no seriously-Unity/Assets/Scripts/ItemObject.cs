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

public class ItemObject : MonoBehaviour
{
    public InventoryItemData referenceItem;

    public void OnHandlePickupItem()
    {
       // InventorySystem.current.Add(referenceItem);
        Destroy(gameObject);
    }

    
    /**private void Update()
    {
        if (!useLookAt)
        {
            _targetPosition = _parent.position + _parent.forward * 2f + new Vector3(0f, 2f, 0f);
        }

        _lookAtTarget.transform.position = Vector3.Lerp(_lookAtTarget.transform.position, _targetPositon, Time.deltaTime * lookSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(_lookAtTarget != null && _lookAtTarget.TryGetComponent<ItemObject>(out ItemObject item))
            {
                ItemObject.OnHandlePickupItem();
                itemController.SetTargetPosition(ItemObject.transform);
                itemController.Pickup();
            }
        }
    }


    public void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.GetComponent<PointOfInterest>())
        {
            _targetPosition = collider.transform.position;
            useLookAt = true;
        }
    }

    public void OnTriggerExit(Collider collider)
    {
        useLookAt = false;
    }**/
}


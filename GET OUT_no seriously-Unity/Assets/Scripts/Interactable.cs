/**** 
 * Created by: Betzaida Ortiz Rivas
 * Date Created: March 6, 2022
 * 
 * Last Edited by: N/A
 * Last Edited:
 * 
 * Description: Updates start canvas referecing game manager
****/

using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f; // distance that player needs to be to interact with object
    public Transform interactionTransform;

    bool isFocus = false; //check if player is close to interact
    Transform player;

    bool hasInteracted = false;

    public virtual void Interact()
    {
        //method meant to be overwritten
        Debug.Log("Interact with " + transform.name);
    }

    private void Update()
    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if(distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    public void OnFocused (Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }


    private void OnDrawGizmosSelected()
    {
        //don't get errors in console
        if(interactionTransform == null)
        {
            interactionTransform = transform;
        }

        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(interactionTransform.position, radius); // wire sphere around interactable

    }
}

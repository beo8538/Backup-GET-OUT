/**** 
 * Created by: Betzaida Ortiz Rivas
 * Date Created: March 12, 2022
 * 
 * Last Edited by: NA
 * Last Edited:
 * 
 * Description: Canvas is triggered when within certain collisions
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //libraries for UI components

public class PopUpCanvas : MonoBehaviour
{

    [SerializeField] private Image ComputerImage;

    private void OnTriggerEnter(Collider computer)
    {
        if (computer.CompareTag("Player"))
        {
            ComputerImage.enabled = true;
        }
    }

    private void OnTriggerExit(Collider computer)
    {
        if (computer.CompareTag("Player"))
        {
            ComputerImage.enabled = false;
        }
    }
}

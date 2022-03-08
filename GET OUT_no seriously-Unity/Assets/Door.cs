/**** 
 * Created by: Betzaida Ortiz Rivas
 * Date Created: March 7, 2022
 * 
 * Last Edited by: NA
 * Last Edited:
 * 
 * Description: trigger to go to next scene
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    GameManager = Gm;

    //state of the door
    int stateDoor = 1;

    public int NextLevel;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (GetDoorState() == 3)
        {
            Gm.LoadNextLevel();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

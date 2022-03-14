/**** 
 * Created by: Betzaida Ortiz Rivas
 * Date Created: March 2, 2022
 * 
 * Last Edited by: N/A
 * Last Edited:
 * 
 * Description: creates scriptable assets (the pictures and stuff)
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory Item Data")] //creates option to create this in menu

public class InventoryItemData : ScriptableObject
{
    public string displayName; //name
    public Sprite icon; //icon of item
    public GameObject prefab; //grab item's prefab
}

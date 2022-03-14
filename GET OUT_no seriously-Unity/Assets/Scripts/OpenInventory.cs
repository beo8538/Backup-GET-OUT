using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{

    public GameObject Panel;

    public void OpenPanel()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            Panel.gameObject.SetActive(!Panel.gameObject.activeSelf);
        }
    }
}

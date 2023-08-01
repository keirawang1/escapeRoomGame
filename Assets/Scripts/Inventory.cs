using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    void Start()
    {
        InitializeInventory();
    }

    void InitializeInventory()
    {
        var slot_var = GameObject.Find("slots");
        foreach(Transform slot in slot_var.transform){
            slot.transform.GetChild(0).GetComponent<Image>().sprite = 
                Resources.Load<Sprite>("Inventory/inventory_empty");
        }
    }
}

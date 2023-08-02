using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject currentSelectedSlot {get; set;}
    public GameObject previousSelectedSlot {get; set;}

    private GameObject slot_var;

    void Start(){
        InitializeInventory();
        slot_var = GameObject.Find("slots");
    }

    void Update(){
        SelectSlot();
    }

    void InitializeInventory(){
        var slot_var = GameObject.Find("slots");
        foreach(Transform slot in slot_var.transform){
            slot.transform.GetChild(0).GetComponent<Image>().sprite = 
                Resources.Load<Sprite>("Inventory/inventory_empty");
        }
    }

    void SelectSlot(){
        foreach(Transform slot in slot_var.transform){
            if(slot.gameObject == currentSelectedSlot && slot.GetComponent<Slot>().ItemProperty == Slot.property.usable){
                slot.GetComponent<Image>().color = new Color(.75f, .6f, .3f, 9);
            }
            else{
                slot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    private GameObject inventory_var;
    
    public enum property {usable, displayable};
    public property ItemProperty{get; private set;}

    void Start(){
        inventory_var = GameObject.Find("inventory");
    }

    public void OnPointerClick(PointerEventData eventData){
        inventory_var.GetComponent<Inventory>().previousSelectedSlot = inventory_var.GetComponent<Inventory>().currentSelectedSlot;
        inventory_var.GetComponent<Inventory>().currentSelectedSlot = this.gameObject;
    }

    public void AssignProperty(int orderNumber){
        ItemProperty = (property)orderNumber;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour, Interactable {

    public string DisplaySprite;

    private GameObject InventorySlots;

    public void Interact(DisplayImage currentDisplay){
        ItemPickUp();
    }

    void Start(){
        InventorySlots = GameObject.Find("slots");
    }

    void ItemPickUp(){
        foreach(Transform slot in InventorySlots.transform){
            if(slot.transform.GetChild(0).GetComponent<Image>().sprite.name == "inventory_empty"){
                slot.transform.GetChild(0).GetComponent<Image>().sprite =
                    Resources.Load<Sprite>("Inventory/" + DisplaySprite);
                Destroy(gameObject);
                break;
            }
        }
    }

}

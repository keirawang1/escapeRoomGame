using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImage : MonoBehaviour
{
    public int CurrentRoom {
        get { return currentRoom; }
        set {
            if (value == 5)
                currentRoom = 1;
            else if (value == 0)
                currentRoom = 4;
            else   
                currentRoom = value;
        }
    }
    private int currentRoom;
    private int previousRoom;

    void Start() {
        previousRoom = 0;
        currentRoom = 1;
    }

    void Update() {
        if(currentRoom != previousWall) {
            GetComponent<SpriteRenderer>().sprite - Resources.Load<Sprite>("Sprites/room" + currentRoom.ToString());

        }

        previousWall = currentWall;
    }
}

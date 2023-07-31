using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private DisplayImage currentDisplay;

    // Start is called before the first frame update
    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        
    }

    public void OnRightClickArrow() {
        currentDisplay.CurrentRoom = currentDisplay.CurrentRoom + 1;

    }

    public void OnLeftClickArrow() {
        currentDisplay.CurrentRoom = currentDisplay.CurrentRoom - 1;

    }

}

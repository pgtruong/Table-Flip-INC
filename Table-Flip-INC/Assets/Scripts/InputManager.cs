using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public bool finger = false;
    
    void Update()
    {
        //Checks if input and if you swipe upwards
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                finger = true;
            }
            else if ((Input.GetTouch(0).deltaPosition.y > 1f && finger && Input.GetTouch(0).deltaPosition.x >= -0.25f && Input.GetTouch(0).deltaPosition.x <= 0.25f))
            {
                finger = false;
                GameManager.instance.changeGold(100);
                GameManager.instance.incrementTable();
            }
        }

        //For Editor Purposes to test.
        else if (Input.GetMouseButtonDown(0))
        {
            GameManager.instance.changeGold(100);
            GameManager.instance.incrementTable();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableScript : MonoBehaviour {

    bool flip = false;
    public GameObject table;

    void Update()
    {
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0) && !flip)
        {
            flip = true;
            GameObject temp = Instantiate(table);
            temp.name = "Table";
        }                    
        if (flip)
        {            
            transform.position = Vector3.Slerp(transform.position, new Vector3(11, -2, 0), Time.deltaTime * 3f);
            if (!GetComponent<SpriteRenderer>().isVisible)
            {
                Destroy(gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableScript : MonoBehaviour {

    bool flip = false;
    public GameObject table;
    Vector3 endPos;
    bool finger = false; 

    void Start()
    {
        endPos = new Vector3(11, Random.Range(-4, -15), 0);
    }

    void Update()
    {          
        //Sets Slerp Arc
        Vector3 center = (transform.position + endPos) * 0.5f;
        center -= new Vector3(0, 1, 0);
        Vector3 startRelCenter = transform.position - center;
        Vector3 endRelCenter = endPos - center;

        //Sets when it should be flying in da ayer       
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began && !flip)
            {
                finger = true;
            }
            else if ((Input.GetTouch(0).deltaPosition.y > 1f && finger && Input.GetTouch(0).deltaPosition.x <= 0.2f && Input.GetTouch(0).deltaPosition.x >= -0.2f) && !flip)
            {
                flip = true;
                GameObject temp = Instantiate(table);
                temp.name = "Table";
            }
        }

        else if (Input.GetMouseButtonDown(0) && !flip)
        {
            flip = true;
            GameObject temp = Instantiate(table);
            temp.name = "Table";
        }
                           
        if (flip)
        {
            transform.Rotate(new Vector3(0,0,-1) * 7);
            transform.position = Vector3.Slerp(startRelCenter, endRelCenter, Time.deltaTime * 1.5f);
            transform.position += center;
            if (!GetComponent<SpriteRenderer>().isVisible)
            {
                Destroy(gameObject);
            }
        }
    }
}

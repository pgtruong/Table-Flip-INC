using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text gold;
    public Text tablesFlipped;

    void Update()
    {
        gold.text = "Gold: " + GameManager.instance.gold.ToString();
        tablesFlipped.text = "Tables Flipped: " + GameManager.instance.tablesFlipped.ToString();
    }
}

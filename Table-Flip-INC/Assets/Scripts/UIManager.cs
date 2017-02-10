using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text score;

    void Update()
    {
        score.text = "Score: " + GameManager.instance.gold.ToString();
    }
}

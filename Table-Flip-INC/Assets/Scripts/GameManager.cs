using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    //public AudioManager audioManager;
    public bool inputActive = true;
    public int gold;
    float goldMultiplier = 1;
    public int tablesFlipped = 0;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }

    public void changeGold(int delta)
    {
        gold += Mathf.RoundToInt(delta * goldMultiplier);
    }

    public void setMultiplier(float mult)
    {
        goldMultiplier = mult;
    }

    public void incrementTable(int delta = 1)
    {
        tablesFlipped += delta;
    }

}

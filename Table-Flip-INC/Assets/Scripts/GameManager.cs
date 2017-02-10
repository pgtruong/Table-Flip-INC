using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    //public AudioManager audioManager;
    public bool inputActive = true;
    public int gold;

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
        gold += delta;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    static public Controller Instance;

    public int Count;
    public GameObject Wintext;
    private int onCount = 0;

    public GameObject Breaker;

    private void Awake()
    {
        Instance = this;
    }

    public void SwitchChange(int points)
    {
        onCount = onCount + points;
        if(onCount == Count)
        {
            Wintext.SetActive(true);
            Breaker.tag = "Finished";
        }
    }
}

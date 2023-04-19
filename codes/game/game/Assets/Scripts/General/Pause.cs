using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject PuaseMenu;
    


    public void Resume()
    {
        PuaseMenu.SetActive(false);
        Time.timeScale = 1f;
      
    }

    public void Pauses()
    {
        PuaseMenu.SetActive(true);
        Time.timeScale = 0f;
      
    }
}

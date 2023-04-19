using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music2 : MonoBehaviour
{
    Dont don;

    //public AudioSource ai;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestoryMusic()
    {
        //var games = GameObject.FindGameObjectWithTag("Timer");
        //games
        Destroy(GameObject.FindGameObjectWithTag("Before"));
    }
}

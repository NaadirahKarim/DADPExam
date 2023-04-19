using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryTimer : MonoBehaviour
{
    Timer times;

    public void Destorytime()
    {
        //var games = GameObject.FindGameObjectWithTag("Timer");
        //games
        Destroy(GameObject.FindGameObjectWithTag("Timer"));
    }
}

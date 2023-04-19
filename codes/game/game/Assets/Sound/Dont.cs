using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

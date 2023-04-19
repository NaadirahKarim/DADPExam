using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButton : MonoBehaviour
{
    public GameObject game1;
    public GameObject game2;
    public GameObject game3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((game1.tag== "Finished") && (game2.tag == "Finished"))
        {
            game3.SetActive(true);
        }
        
    }
}

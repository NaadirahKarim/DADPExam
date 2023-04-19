using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    public GameObject backs;

    public GameObject a;
    public GameObject s;
    public GameObject d;
    public GameObject f;
    public GameObject g;
    public GameObject h;
    public GameObject j;
    public GameObject k;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBack()
    {
        backs.SetActive(false);

        a.SetActive(true);
        s.SetActive(true);
        d.SetActive(true);
        f.SetActive(true);
        g.SetActive(true);
        h.SetActive(true);
        j.SetActive(true);
        k.SetActive(true);
    }
}

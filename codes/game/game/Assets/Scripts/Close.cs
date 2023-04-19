using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public GameObject Closep;
    public GameObject Act;
    public GameObject Ac;

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

    private void OnMouseUp()
    {
        Closep.SetActive(false);
        Act.SetActive(true);
        Ac.SetActive(true);

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

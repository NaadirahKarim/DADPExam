using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enable : MonoBehaviour
{
    public GameObject a;
    public GameObject s;
    public GameObject d;
    public GameObject f;
    public GameObject g;
    public GameObject h;
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

        a.SetActive(true);
        s.SetActive(true);
        d.SetActive(true);
        f.SetActive(true);
        g.SetActive(true);
        h.SetActive(true);
    }
}

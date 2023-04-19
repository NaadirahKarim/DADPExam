using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{

    public GameObject open;

    public GameObject a;
    public GameObject s;
    public GameObject d;
    public GameObject f;
    public GameObject g;
    public GameObject h;
    public GameObject j;
    public GameObject k;

    public AudioSource aud;
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
        aud.Play();
        open.SetActive(true);
        a.SetActive(false);
        s.SetActive(false);
        d.SetActive(false);
        f.SetActive(false);
        g.SetActive(false);
        h.SetActive(false);
        j.SetActive(false);
        k.SetActive(false);
    }
}

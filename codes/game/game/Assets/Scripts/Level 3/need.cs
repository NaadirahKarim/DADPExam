using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class need : MonoBehaviour
{
    public GameObject cure;

    public GameObject q;
    public GameObject w;
    public GameObject e;
    public GameObject r;
    public GameObject t;

    public GameObject y;
    private void Update()
    {
        if ((q.tag == "Cure") && (w.tag == "Cure") && (e.tag == "Cure") && (r.tag == "Cure") && (t.tag == "Cure"))
        {
            cure.SetActive(true);
            y.SetActive(false);
        }
    }
}

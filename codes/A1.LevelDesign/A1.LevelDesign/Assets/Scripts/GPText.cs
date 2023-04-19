using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPText : MonoBehaviour
{
    public GameObject gPText;

    public void Start()
    {
        gPText.SetActive(false);
    }

    public void OnMouseOver()
    {
        gPText.SetActive(true);
    }

    public void OnMouseExit()
    {
        gPText.SetActive(false);
    }
}

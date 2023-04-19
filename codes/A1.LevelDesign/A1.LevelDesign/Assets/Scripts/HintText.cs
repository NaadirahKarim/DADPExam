using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintText : MonoBehaviour
{
    public GameObject hintText;

    public void Start()
    {
        hintText.SetActive(false);
    }

    public void OnMouseOver()
    {
        hintText.SetActive(true);
    }

    public void OnMouseExit()
    {
        hintText.SetActive(false);
    }
}

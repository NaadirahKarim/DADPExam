using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullText : MonoBehaviour
{
    public GameObject skullText;

    public void Start()
    {
        skullText.SetActive(false);
    }

    public void OnMouseOver()
    {
        skullText.SetActive(true);
    }

    public void OnMouseExit()
    {
        skullText.SetActive(false);
    }
}

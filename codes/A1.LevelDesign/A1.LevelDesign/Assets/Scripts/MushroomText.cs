using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomText : MonoBehaviour
{
    public GameObject mushroomText;

    public void Start()
    {
        mushroomText.SetActive(false);
    }

    public void OnMouseOver()
    {
       mushroomText.SetActive(true);
    }

    public void OnMouseExit()
    {
        mushroomText.SetActive(false );
    }
}

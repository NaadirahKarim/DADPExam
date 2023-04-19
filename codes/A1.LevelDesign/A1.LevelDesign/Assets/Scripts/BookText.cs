using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookText : MonoBehaviour
{
    public GameObject bookText;

    public void Start()
    {
        bookText.SetActive(false);
    }

    public void OnMouseOver()
    {
        bookText.SetActive(true);
    }

    public void OnMouseExit()
    {
        bookText.SetActive(false);
    }
}

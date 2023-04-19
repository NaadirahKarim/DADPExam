using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureActive : MonoBehaviour
{
    public GameObject Right;
    public GameObject cure;

    private void OnMouseUp()
    {
        Right.SetActive(true);
        Right.tag = "Cure";
    }
}

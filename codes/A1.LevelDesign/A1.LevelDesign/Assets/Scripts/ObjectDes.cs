using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDes : MonoBehaviour
{
    public GameObject Objectnametext;
    public AudioSource collectSound;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(Objectnametext);
        collectSound.Play();
    }
}

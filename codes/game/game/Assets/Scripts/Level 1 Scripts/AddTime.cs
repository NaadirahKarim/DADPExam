using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTime : MonoBehaviour
{
    public GameObject Pain;

    Timer timez;

    public Sprite normal;
    private SpriteRenderer rend;

    public AudioSource a;

    void Start()
    {
        rend = GameObject.FindGameObjectWithTag("Cursors").GetComponent<SpriteRenderer>();
    }

    public void OnMouseUp()
    {
        a.Play();
        rend.sprite = normal;
        Pain.SetActive(false);
        var game = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        game.AddTime(120);
    }
}

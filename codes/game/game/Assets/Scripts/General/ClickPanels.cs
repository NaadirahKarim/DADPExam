using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPanels : MonoBehaviour
{
    public GameObject openPanel;
    public GameObject disGame;
    public GameObject disGame2;

    public Sprite normal;
    private SpriteRenderer rend;


    private void OnMouseUp()
    {
        rend.sprite = normal;
        openPanel.SetActive(true);
        disGame.SetActive(false);
        disGame2.SetActive(false);
    }
    void Start()
    {
        rend = GameObject.FindGameObjectWithTag("Cursors").GetComponent<SpriteRenderer>();
    }
}

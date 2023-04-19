using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite Over;
    public Sprite normal;

    // Start is called before the first frame update
    void Start()
    {
        rend = GameObject.FindGameObjectWithTag("Cursors").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        rend.sprite = Over; 
    }

    private void OnMouseExit()
    {
        rend.sprite = normal;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursors : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite normal;

    void Start()
    {
        Cursor.visible = false;
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = normal;
    }


    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
    }
}

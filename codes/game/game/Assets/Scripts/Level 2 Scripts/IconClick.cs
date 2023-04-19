using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconClick : MonoBehaviour
{
    public AddProgress increase;
    public ProgessBar proBar;

    float lastClickTime;
    const float DoubleClickTime = .2f;

    private BoxCollider2D col;

    private void Start()
    {
        col = GetComponent<BoxCollider2D>();
    }

    private void OnMouseUp()
    {
        float timeSinceLast = Time.time - lastClickTime;
        if (timeSinceLast <= DoubleClickTime)
        {
            Debug.Log("ADD");
            increase.IncreasePro(20);
            col.enabled = false;
        }
        else
        {

        }
        lastClickTime = Time.time;
    }
}

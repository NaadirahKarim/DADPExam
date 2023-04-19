using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNews : MonoBehaviour
{
    [SerializeField] public GameObject openPanel;

    private BoxCollider2D col;
    public AudioSource au;

    void Start()
    {
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUp()
    {
        col.enabled = false;
        openPanel.SetActive(true);
        col.enabled = true;
        au.Play();
    }
}

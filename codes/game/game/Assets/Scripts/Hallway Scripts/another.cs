using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class another : MonoBehaviour
{
    public GameObject a;
    private BoxCollider2D col;
    string box;

    [SerializeField] public Text messageb;
    [SerializeField] public int lettersper;

    private void Start()
    {
        col = GetComponent<BoxCollider2D>();
    }

    private void OnMouseUp()
    {
        a.SetActive(true);
        col.enabled = false;
        messageb.text = box;
        StartCoroutine(StartText());
    }

    public IEnumerator TypeBox(string box)
    {
        messageb.text = "";
        foreach (var letter in box.ToCharArray())
        {
            messageb.text += letter;
            yield return new WaitForSeconds(1f / lettersper);
        }
    }
    public IEnumerator StartText()
    {
        yield return TypeBox("Hint:The passcode is simple, recall the number of wires, correct folders and ingredients used to make the antidote…");
        yield return new WaitForSeconds(0.5f);
        a.SetActive(false);
        col.enabled = true;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDia : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
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
        b.SetActive(false);
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
        yield return TypeBox("Hint: The colour of the drug poison");
        yield return new WaitForSeconds(0.5f);
        a.SetActive(false);
        col.enabled = true;
        b.SetActive(true);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LooseTimeIcon : MonoBehaviour
{
    Timer times;

    float lastClickTime;
    const float DoubleClickTime = .2f;

    private BoxCollider2D col;

    public GameObject a;
   // private BoxCollider2D col;
    string box;

    [SerializeField] public Text messageb;
    [SerializeField] public int lettersper;

    private void Start()
    {
        col = GetComponent<BoxCollider2D>();
    }

    private void OnMouseUp()
    {
        float timeSinceLast = Time.time - lastClickTime;
        if(timeSinceLast <= DoubleClickTime)
        {
            a.SetActive(true);
            //col.enabled = false;
            messageb.text = box;
            StartCoroutine(StartText());

            Debug.Log("DD");
            var games = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
            games.RemoveTIme(60);
            col.enabled = false;

            //a.SetActive(true);
            //col.enabled = false;
            //messageb.text = box;
            //StartCoroutine(StartText());

        }
        else
        {
            
        }
        lastClickTime = Time.time;
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
        yield return TypeBox("Warning: Incorrect choice. Time will be decreased by 1 min, BE CAREFUL!");
        yield return new WaitForSeconds(0.5f);
        a.SetActive(false);
        //col.enabled = true;
    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDialogue : MonoBehaviour
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
        yield return TypeBox($"21st November 2021"+ "\n"+"\n" + "High school victim claims he was abducted after returning home from school.Victim stated that they were taken to Oak Asylum that had recently shutdown and was drugged with a PURPLE like liquid that caused severe heartache and pain throughout the joints.Victim accuses former employee, Doctor Brown from the asylum for selling organs on the black market.Victim found a list of individuals between the ages of 15 – 20, non - smoker and non - drinker.The victim escaped the asylum after drinking an antidote, a blue tonic." +"\n"+ "\n"+
        "Accusations made against Dr Brown were false and evidence was brought forward that he transferred to a private hospital in a different location.No further investigation was carried out after the trial that led to Dr Brown’s innocence and his return home.");
        yield return new WaitForSeconds(1f);
        a.SetActive(false);
        col.enabled = true;
        b.SetActive(true);
    }
}
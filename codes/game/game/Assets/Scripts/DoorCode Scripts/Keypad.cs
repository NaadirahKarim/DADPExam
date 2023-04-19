using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    [SerializeField] public Text Ans;

    public GameObject Win;

    private string Answer = "555";

    Timer times;

    Dont don;

    public void Number(int Number)
    {
        if(Ans.text == "")
        {
            Ans.text = "";
            Ans.text += Number.ToString();
        }
        else
        Ans.text += Number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "Valid";
            Win.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("Timer"));
            Destroy(GameObject.FindGameObjectWithTag("Before"));
        }
        else
        {
            Ans.text = "";
        }

    }

    public void Clear()
    {
        Ans.text = "";
    }
}

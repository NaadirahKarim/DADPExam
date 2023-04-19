using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogIn : MonoBehaviour
{
    [SerializeField] public Text messageText;
    //[SerializeField] public InputField UserInput;
    [SerializeField] public InputField passInput;
    [SerializeField] public GameObject OpennextPanel;
    [SerializeField] public GameObject ClosePanel;


    public void LoginButton()
    {
        if ((passInput.text == "purple"))
        {
            messageText.text = "Logged-In";
            OpennextPanel.SetActive(true);
            ClosePanel.SetActive(false);
           // UserInput.text = "";
            passInput.text = "";
            messageText.text = "";
        }
        else
            messageText.text = "Username or Password is incorrect";
    }
}

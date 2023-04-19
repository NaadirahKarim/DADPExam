using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject patient;

    [SerializeField]
    private Slider patientHealth;

    //Buttons
    [SerializeField]
    private Button purpleButton;

    [SerializeField]
    private Button topazButton;

    [SerializeField]
    private Button dLeavesButton;

    [SerializeField]
    private Button lSakuraButton;

    [SerializeField]
    private Button wFButton;

    public Text playerHP;

    private void Attack(GameObject target, int damage)
    {

        if (target == patient)
        {
            
            patientHealth.value -= damage;
            Text();

            if (patientHealth.value <= 0)
            {
                patientHealth.value = 0;
                Debug.Log("YOU LOSE");
                SceneManager.LoadScene("LoseScene");
            }

        }
        
    }

    //TextFunctions for the health and mana bars
    public void Text()
    {
        playerHP.text = patientHealth.value.ToString();
    }

    public void PurpleButton()
    {

        Attack(patient, 20);

    }

    public void TopazButton()
    {

        Attack(patient, 20);
    }

    public void DlEavesButton()
    {

        Attack(patient, 20);
    }

    public void LSakuraButton()
    {

        Attack(patient, 20);
    }

    public void WFButton()
    {

        Attack(patient, 20);
    }
}

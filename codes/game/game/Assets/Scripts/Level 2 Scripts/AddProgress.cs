using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddProgress : MonoBehaviour
{
    public int maxPro = 100;
    public int minPro = 0;
    public int currentPro;

    public ProgessBar proBar;

    public GameObject Next;

    void Start()
    {
        currentPro = minPro;
        proBar.SetMaxValue(minPro);
        
    }

    void Update()
    {
        Shows();
    }

    public void IncreasePro(int add)
    {
        currentPro += add;

        proBar.SetProgress(currentPro);
    }

    public void Shows()
    {
        if(currentPro == maxPro)
        {
            Next.SetActive(true);
        }
    }
    
    
}

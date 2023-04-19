using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] public GameObject up;
    [SerializeField] public GameObject on;
    [SerializeField] public GameObject up1;
    [SerializeField] public GameObject on1;
    [SerializeField] public bool isOn;
    [SerializeField] public bool isUp;
    [SerializeField] public bool isOn1;
    [SerializeField] public bool isUp1;

    void Start()
    {
        on.SetActive(isOn);
        up.SetActive(isUp);
        if (isOn)
        {
            Controller.Instance.SwitchChange(1);
        }
        
    }

    private void OnMouseUp()
    {
        isUp = !isUp;
        isOn = !isOn;
        on.SetActive(isOn);
        up.SetActive(isUp);
        //isUp1 = !isUp1;
        isOn1 = !isOn1;
        on1.SetActive(isOn1);
        //up1.SetActive(isUp1);
        if (isOn)
        {
            Controller.Instance.SwitchChange(1);
        }else
        {
            Controller.Instance.SwitchChange(-1);
        }
        //Controller.Instance.SwitchChange(isOn ? 1 : -1);

    }


}

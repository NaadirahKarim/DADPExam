using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonSystem : MonoBehaviour
{
    EventSystem system;
    [SerializeField] public Selectable fInput;
    [SerializeField] public Button submitBot;

    void Start()
    {
        system = EventSystem.current;
        fInput.Select();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
        {
            Selectable previous = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
            if (previous != null)
            {
                previous.Select();
            }
        } else if (Input.GetKeyDown(KeyCode.Tab))
        {
            Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
            if (next != null)
            {
                next.Select();
            }
        }else if (Input.GetKeyDown(KeyCode.Return))
        {
            submitBot.onClick.Invoke();
            Debug.Log("Button Pressed");
        }
        
    }

    public void ButtonClick()
    {
        Debug.Log("Button Pressed");
    }
}

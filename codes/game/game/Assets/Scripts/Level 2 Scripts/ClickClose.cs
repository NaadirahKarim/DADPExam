using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickClose : MonoBehaviour
{
    [SerializeField] public GameObject closePanel;
    [SerializeField] public GameObject enGame;

    private void OnMouseUp()
    {
        closePanel.SetActive(false);
        enGame.SetActive(true);
    }
}

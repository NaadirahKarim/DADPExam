using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickClosePanel : MonoBehaviour
{
    public GameObject closePanel;
    public GameObject enGame;
    public GameObject enGame2;

    private void OnMouseUp()
    {
        closePanel.SetActive(false);
        enGame.SetActive(true);
        enGame2.SetActive(true);
    }
}

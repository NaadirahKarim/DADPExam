using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Freeze : MonoBehaviour
{
    public void Resume()
    {
        //PuaseMenu.SetActive(false);
        //var sc = SceneManager.GetActiveScene();
        Time.timeScale = 1f;
        //sc.

    }

    public void Pauses()
    {
        //SceneManager.GetActiveScene();
        Time.timeScale = 0f;

    }
}

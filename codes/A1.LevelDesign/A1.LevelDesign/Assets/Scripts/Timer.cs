using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public string sceneToLoad;
    private float timerCount = 60f;
    private Text timerSeconds;

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timerCount -= Time.deltaTime;
        timerSeconds.text = timerCount.ToString("f0");
        if(timerCount <= 0)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

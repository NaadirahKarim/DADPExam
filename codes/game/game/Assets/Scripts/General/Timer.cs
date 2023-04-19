using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time = 600;
    public TextMeshPro timeText;
    private float result;

    [SerializeField] public Timer Instance;
    //[SerializeField] public AudioSource p;
    Dont don;



    private void Awake()
    {
        //time = 600f;
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        //DontDestroyOnLoad(p);
    }

    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
            //time = result;
        }else //if (time==60)
       // {
        //    p.Play();
         //   time -= Time.deltaTime;
        //}
        {
            time = 0;
            Destroy(GameObject.FindGameObjectWithTag("Timer"));
            Destroy(GameObject.FindGameObjectWithTag("Before"));
            SceneManager.LoadScene("DeathScene");
        }

        DisplayTime(time);
        //inc.OnMouseUp();
        //RemoveTIme();
        //AddTime();
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void RemoveTIme(int Remove)
    {
            time = time - Remove;
    }

    public void AddTime(int increase)
    {
            time = time + increase;
    }
}

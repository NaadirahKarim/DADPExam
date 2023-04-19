using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDesAudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}

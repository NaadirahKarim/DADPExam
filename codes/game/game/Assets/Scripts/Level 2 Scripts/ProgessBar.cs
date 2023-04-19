using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgessBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxValue(int Progress)
    {
        slider.minValue = Progress;
        slider.value = Progress;
    }
    public void SetProgress(int Progress)
    {
        slider.value = Progress;
    }
}

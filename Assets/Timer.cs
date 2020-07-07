using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float timer;
    public TextMeshProUGUI timerText;
    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = timer.ToString("0");

    }
}

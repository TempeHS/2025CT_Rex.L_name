using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI timerText;
    [SerializeField] public float currentTime = 10f;
    private bool active = true;

    public LevelManager levelManager;
    public clockCollect clockCollect;
    public TimeLostController timeLostController;

    [SerializeField] private timeSave timeSO;

    private void Update()
    {
        if (!active)
            return;

        currentTime -= Time.deltaTime;
        UpdateTimerUI();

        if (currentTime <= 0)
        {
            StopTimer();

            levelManager.GameLost();
        }
    }


    public void StopTimer()
    {
        active = false;
        timeSO = 0f;

        UpdateTimerUI();
    }


    private void UpdateTimerUI()
    {
        if (timeSO > 0 && timeSO < 6)
        {
            timerText.color = Color.yellow;
        }
        else if (timeSO < 1)
        {
            timerText.color = Color.red;
        }
        else
        {
            timerText.color = Color.white;
        }

        TimeSpan t = TimeSpan.FromSeconds(timeSO);
        timerText.text = t.ToString(@"mm\:ss");
    }

    public void DeductTime()
    {
        timeSO -= 10f;
        UpdateTimerUI();
    }

    public void addTime()
    {
        timeSO += 15f;
        UpdateTimerUI();
    }
}

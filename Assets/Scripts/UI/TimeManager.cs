using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI timerText;
    private bool active = true;

    public LevelManager levelManager;
    public clockCollect clockCollect;
    public TimeLostController timeLostController;

    [SerializeField] private timeSave timeSO;

    void Start()
    {
        timerText.text = timeSO.Time + "";
        // timeSO.Time = 60f;
    }


    private void Update()
    {
        if (!active)
            return;

        timeSO.Time -= Time.deltaTime;
        UpdateTimerUI();

        if (timeSO.Time <= 0)
        {
            StopTimer();
            timeSO.Time = 60f;
            levelManager.GameLost();
        }
    }


    public void StopTimer()
    {
        active = false;
        timeSO.Time  = 0f;

        UpdateTimerUI();
    }


    private void UpdateTimerUI()
    {
        if (timeSO.Time > 0 && timeSO.Time < 6)
        {
            timerText.color = Color.yellow;
        }
        else if (timeSO.Time < 1)
        {
            timerText.color = Color.red;
        }
        else
        {
            timerText.color = Color.white;
        }

        TimeSpan t = TimeSpan.FromSeconds(timeSO.Time);
        timerText.text = t.ToString(@"mm\:ss");
    }

    public void DeductTime()
    {
        timeSO.Time -= 10f;
        UpdateTimerUI();
    }

    public void addTime()
    {
        timeSO.Time += 15f;
        UpdateTimerUI();
    }
}

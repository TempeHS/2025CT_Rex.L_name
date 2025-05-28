using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI timerText;
    [SerializeField] public float currentTime = 60f;
    private bool active = true;

    private LevelManager levelManager;

    void Start()
    {
        levelManager = GetComponent<LevelManager>();
    }
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
        currentTime = 0f;

        UpdateTimerUI();
    }


    private void UpdateTimerUI()
    {
        if (currentTime > 0 && currentTime < 6)
        {
            timerText.color = Color.yellow;
        }
        else if (currentTime < 1)
        {
            timerText.color = Color.red;
        }

        TimeSpan t = TimeSpan.FromSeconds(currentTime);
        timerText.text = t.ToString(@"mm\:ss");
    }
}

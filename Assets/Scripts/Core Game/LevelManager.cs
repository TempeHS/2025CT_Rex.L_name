using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class LevelManager : MonoBehaviour
{
    private TimeManager timeManager;
    private LoseTime loseTime;
    private TrapDamage trapDamage;
    private MainMenu mainMenu;

    void Start()
    {
        timeManager = GetComponent<TimeManager>();
        loseTime = GetComponent<LoseTime>();
        trapDamage = GetComponent<TrapDamage>();
        mainMenu = GetComponent<MainMenu>();
    }


    public void GameLost()
    {
        SceneManager.LoadScene("LoseMenu");
    }
}

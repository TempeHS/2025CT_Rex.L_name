using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class LevelManager : MonoBehaviour
{
    public TimeManager timeManager;
    public TrapDamage trapDamage;


    public void GameLost()
    {
        SceneManager.LoadScene("LoseMenu");
    }
}

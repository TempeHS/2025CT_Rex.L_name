using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoseTime : MonoBehaviour
{
    public TrapDamage trapDamage;
    public TimeManager timeManager;
    public LevelManager levelManager;

    public GameObject TimeLostDisplay;

    [SerializeField] public TextMeshProUGUI TimeLostText;

    [SerializeField] public float TimeLost = 5f;

    void Start()
    {
        TimeLostDisplay.SetActive(false);
    }


    public void TimeLose()
    {
        TimeLostDisplay.SetActive(true);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoseTime : MonoBehaviour
{
    private TrapDamage trapDamage;
    private TimeManager timeManager;
    private LevelManager levelManager;

    new GameObject TimeLostDisplay;

    [SerializeField] public TextMeshProUGUI TimeLostText;

    [SerializeField] public float TimeLost = 5f;

    void Start()
    {
        TimeLostDisplay.SetActive(false);

        trapDamage = GetComponent<TrapDamage>();

    }


    public void TimeLose()
    {
        TimeLostDisplay.SetActive(true);
    }
}

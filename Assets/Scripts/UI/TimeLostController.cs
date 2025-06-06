using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeLostController : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject TimeLostDisplay;
    public TextMeshProUGUI TimeDisplay;

    private bool textActive = false;
    [SerializeField] public float timeLose;
    [SerializeField] private float timeToAppear;
    [SerializeField] private float timeToDisappear;

    void Update()
    {
        if (textActive = true && (Time.time >= timeToDisappear))
        {
            TimeLostDisplay.SetActive(false);
            textActive = false;
        }
    }


    public void DisplayLostTime()
    {
        TimeLostDisplay.SetActive(true);
        textActive = true;
        timeToDisappear = Time.time + timeToAppear;
        TimeDisplay.text = "- 00: " + timeLose;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeLostController : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject TimeLostDisplay;
    public TextMeshProUGUI TimeDisplay;

    [SerializeField] public float timeLose;


    public void DisplayLostTime()
    {
        TimeLostDisplay.SetActive(true);

        TimeDisplay.text = "- " + timeLose.ToString();
    }
}

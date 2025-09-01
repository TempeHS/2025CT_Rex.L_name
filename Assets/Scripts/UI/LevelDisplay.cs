using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelDisplay : MonoBehaviour
{
    public TextMeshProUGUI levelDisplay;
    public teleporterLevelOne teleporterLevelOne;
    public teleporterLevelTwo teleporterLevelTwo;
    public int levelNumber = 1;


    public void Update()
    {
        setLevelText();
    }


    public void setLevelText()
    {
        levelDisplay.text = "Level " + levelNumber.ToString();
    }
}

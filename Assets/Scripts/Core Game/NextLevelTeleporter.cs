using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTeleporter : MonoBehaviour
{
    [SerializeField] public string sceneName;
    
    public LevelDisplay levelDisplay;
    public GameObject keyObjectOne;
    public GameObject keyObjectTwo;

    void Start()
    {
        levelDisplay = GetComponent<LevelDisplay>();
        
        if (levelDisplay != null)
        {
            levelDisplay.setLevelText();
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (sceneName == "LevelOne")
        {
            if (other.gameObject.CompareTag("Player") && keyObjectOne.activeInHierarchy == false)
            {
                Debug.Log("Working");
                SceneManager.LoadScene("LevelTwo");
            }
        }

        if (sceneName == "LevelTwo")
        {
            if (other.gameObject.CompareTag("Player") && keyObjectOne && keyObjectTwo.activeInHierarchy == false)
            {
                Debug.Log("Working");
                SceneManager.LoadScene("LevelThree");
            }
        }
        
    }

    public void GoToScene(string sceneName)
    {
        if (levelDisplay != null)
        {
        levelDisplay.levelNumber++;
        }

        SceneManager.LoadScene(sceneName);
    }
}

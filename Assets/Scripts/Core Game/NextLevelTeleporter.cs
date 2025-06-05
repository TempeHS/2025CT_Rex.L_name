using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTeleporter : MonoBehaviour
{
    [SerializeField] private string sceneName;
    
    public LevelDisplay levelDisplay;

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
        if (other.gameObject.CompareTag("Player"))
        {
            GoToScene(sceneName);
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

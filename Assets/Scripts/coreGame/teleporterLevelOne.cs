using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTeleporter : MonoBehaviour
{
    [SerializeField] public string sceneName;
    
    public LevelDisplay levelDisplay;
    public GameObject keyMain;

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
            if (other.gameObject.CompareTag("Player") && keyMain.activeInHierarchy == false)
            {
                Debug.Log("Working");
                GoToScene("LevelTwo");
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

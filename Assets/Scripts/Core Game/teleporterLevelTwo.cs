using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleporterLevelTwo : MonoBehaviour
{

      [SerializeField] public string sceneName;
      public GameObject keyOne;
      public GameObject keyTwo;
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
            if (other.gameObject.CompareTag("Player") && keyOne && keyTwo.activeInHierarchy == false)
            {
                  GoToScene("LevelThree");
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

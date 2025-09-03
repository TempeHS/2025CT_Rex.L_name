using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
      [Header("Scene Settings")]
      [SerializeField] private string targetSceneName;

      [Header("Key Requirements")]
      [SerializeField] private List<GameObject> requiredKeys;

      [SerializeField] Animator transitionAnim;
      private LevelDisplay levelDisplay;

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
            if (other.CompareTag("Player") && AllKeysCollected())
            {
                  Debug.Log($"Teleporting to {targetSceneName}");
                  GoToScene();
            }
      }

      private bool AllKeysCollected()
      {
            foreach (GameObject key in requiredKeys)
            {
                  if (key != null && key.activeInHierarchy)
                  {
                        return false; // Key still active, not collected
                  }
            }
            return true;
      }

      private void GoToScene()
      {
            if (levelDisplay != null)
            {
                  levelDisplay.levelNumber++;
            }
            
      }

      IEnumerator LoadLevel()
      {
            SceneManager.LoadScene(targetSceneName);
      }
}

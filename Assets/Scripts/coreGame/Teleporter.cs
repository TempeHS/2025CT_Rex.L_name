using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
      [Header("Key Requirements")]
      [SerializeField] private List<GameObject> requiredKeys;

      [SerializeField] Animator transitionAnim;
      public LevelDisplay levelDisplay;

      void Start()
      {

            if (levelDisplay != null)
            {
                  levelDisplay.setLevelText();
            }
      }


      void OnTriggerEnter2D(Collider2D other)
      {
            if (other.CompareTag("Player") && AllKeysCollected())
            {
                  StartCoroutine(LoadLevel());
            }
      }


      private bool AllKeysCollected()
      {
            foreach (GameObject key in requiredKeys)
            {
                  if (key != null && key.activeInHierarchy)
                  {
                        return false;
                  }
            }
            return true;
      }


      private IEnumerator LoadLevel()
      {
            transitionAnim.SetTrigger("End");
            yield return new WaitForSeconds(1f);
            levelDisplay.levelNumber++;
            transitionAnim.SetTrigger("Start");
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
      }
}

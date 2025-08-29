using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySystem : MonoBehaviour
{
      [SerializeField] GameObject KeyMain;

      void OnTriggerEnter2D(Collider2D other)
      {
            if (other.gameObject.CompareTag("Player"))
            {
                  KeyMain.SetActive(false);
            }
      }
}

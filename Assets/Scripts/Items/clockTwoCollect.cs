using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockTwoCollect : MonoBehaviour
{
      public TimeManager timeManager;

      [SerializeField] GameObject ClockTwo;

      void OnTriggerEnter2D(Collider2D other)
      {
            if (other.gameObject.CompareTag("Player"))
            {
                  ClockTwo.SetActive(false);
                  timeManager.addTime();
            }
      }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockCollect : MonoBehaviour
{
      public TimeManager timeManager;

      [SerializeField] GameObject ClockOne;

      void OnTriggerEnter2D(Collider2D other)
      {
            if (other.gameObject.CompareTag("Player"))
            {
                  ClockOne.SetActive(false);
                  timeManager.addTime();
            }
      }
}

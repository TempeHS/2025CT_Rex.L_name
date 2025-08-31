using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapDamage : MonoBehaviour
{
        public TimeLostController timeLostController;
        public TimeManager timeManager;


        void OnTriggerEnter2D(Collider2D other)
        {
                if (other.gameObject.CompareTag("Player"))
                {
                        timeManager.DeductTime();
                        timeLostController.DisplayLostTime();
                }
        }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapDamage : MonoBehaviour
{
        public LoseTime loseTime;

        void OnTriggerEnter2D(Collider2D other)
        {
                if(other.gameObject.CompareTag("Player"))
                {
                        loseTime.TimeLose();
                }
        }
}

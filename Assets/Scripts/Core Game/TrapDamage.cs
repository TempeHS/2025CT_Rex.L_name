using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapDamage : MonoBehaviour
{
        private LoseTime loseTime;

        void Start()
        {
                loseTime = FindObjectOfType<LoseTime>();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
                if(other.gameObject.CompareTag("Player"))
                {
                        SceneManager.LoadScene("LoseMenu");
                }
        }
}

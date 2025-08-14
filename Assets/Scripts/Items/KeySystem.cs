using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySystem : MonoBehaviour
{
      [SerializeField] GameObject KeyMain;

      void OnCollisionEnter2D(Collision2D col)
      {
            KeyMain.SetActive(false);
      }
}

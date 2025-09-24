using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
      public float speed;
      public int startingPoint;
      public Transform[] points;

      private int i;

      private Rigidbody2D rb;

      private GameObject playerOnPlatform;

      private Vector2 lastPosition;

      void Start()
      {
            rb = GetComponent<Rigidbody2D>();
            transform.position = points[startingPoint].position;
            lastPosition = transform.position;
      }


      void FixedUpdate()
      {
      if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
      {
            i++;
            if (i == points.Length)
            {
                  i = 0;
            }
      }

      Vector2 newPos = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.fixedDeltaTime);
      Vector2 platformVelocity = (newPos - lastPosition) / Time.fixedDeltaTime;
      rb.MovePosition(newPos);

      if (playerOnPlatform != null)
      {
            Rigidbody2D playerRb = playerOnPlatform.GetComponent<Rigidbody2D>();
            playerRb.velocity += platformVelocity;
      }

      lastPosition = newPos;
      }

      private void OnCollisionEnter2D(Collision2D collision)
      {
            if (collision.gameObject.CompareTag("Player"))
            {
                  playerOnPlatform = collision.gameObject;
            }
      }

      private void OnCollisionExit2D(Collision2D collision)
      {
            if (collision.gameObject.CompareTag("Player"))
            {
                  playerOnPlatform = null;
            }
      }
}

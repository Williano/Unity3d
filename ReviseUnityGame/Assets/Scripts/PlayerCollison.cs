using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {

            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
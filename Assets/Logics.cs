using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logics : MonoBehaviour
{
    public GameObject gameOverText; // Reference to the game over text prefab

    void Start()
    {
        // Hide the game over text at the start
        gameOverText.SetActive(false);
    }

    // This function is called when a collision occurs
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the tag "obstacle"
        if (collision.gameObject.CompareTag("obstacle"))
        {
            // Check if the colliding object has the tag "prot"
            if (gameObject.CompareTag("prot"))
            {
                // Show the game over text
                gameOverText.SetActive(true);
                // Stop the game (disable this script)
                enabled = false;
            }
        }
    }
}

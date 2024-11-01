using UnityEngine;

public class ProtCollision : MonoBehaviour
{
    private Score scoreManager; // Reference to the Score script
    
    void Start()
    {
        // Find the Score script in the scene
        scoreManager = GameObject.FindObjectOfType<Score>();
    }

    // This function is called when a collision occurs
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the tag "obstacle"
        if (collision.gameObject.CompareTag("obstacle"))
        {
            // Trigger game over and display the accumulated score
            scoreManager.GameOver();
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private bool gameOver = false;
    public int levelTarget = 20; // Public variable for level target score

    // Start is called before the first frame update
    void Start()
    {
        // Initialize score text
        scoreText.text = "Score: " + score.ToString();
        // Start the scoring routine
        InvokeRepeating("UpdateScore", 1f, 1f); // Call UpdateScore every second after 1 second delay
    }

    // Update is called once per frame
    void Update()
    {
        // Check for game over condition and pause the game
        if (gameOver && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f; // Resume the game
            gameOver = false; // Reset game over flag
            score = 0; // Reset score
            scoreText.text = "Score: " + score.ToString(); // Reset score text
                    RestartGame();

        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            QuitGame();
        }
     
    }

    // Function to update the score
    void UpdateScore()
    {
        if (!gameOver)
        {
            score += 2; // Increment score by 2
            scoreText.text = "Score: " + score.ToString(); // Update score text

            // Check if the score reaches the level target
            if (score >= levelTarget)
            {
                MissionAccomplished();
            }
        }
    }

    // Function to change text to "Mission Accomplished" and pause the game
    void MissionAccomplished()
    {
        gameOver = true;
        scoreText.text = "Mission Accomplished\nPress 'Space' to restart the Game or 'X' to quit the game";
        Time.timeScale = 0f; // Pause the game
        if (Input.GetKeyDown(KeyCode.Space))
            {
                RestartGame();
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                QuitGame();
            }
    }

    // Function to change text to "Game Over" and show the accumulated score
    public void GameOver()
    {
        gameOver = true;
        scoreText.text = "Game Over\nPress 'Space' to restart the Game or 'X' to quit the game\nScore: " + score.ToString();
        Time.timeScale = 0f; // Pause the game
    }
    void RestartGame()
{
    // Reload the current scene
    UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
}
void QuitGame()
{
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
}

}

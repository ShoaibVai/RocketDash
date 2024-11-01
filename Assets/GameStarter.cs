using UnityEngine;
using UnityEngine.UI;

public class GameStarter : MonoBehaviour
{
    public Text pauseText;

    private bool gamePaused = true;

    // Update is called once per frame
    void Update()
    {
        if (gamePaused)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ResumeGame();
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                QuitGame();
            }
        }
    }

    void Start()
    {
        PauseGame();
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // Pause the game
        pauseText.text = "Press 'Space' to Start or 'X' to quit the game";
        gamePaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Resume the game
        pauseText.text = "";
        gamePaused = false;
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

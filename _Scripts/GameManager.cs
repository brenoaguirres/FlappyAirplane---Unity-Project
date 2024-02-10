using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Score playerScore;
    private GUIController guiController;

    protected virtual void Awake()
    {
        NewGame();
    }

    public void NewGame()
    {
        guiController = GameObject.FindObjectOfType<GUIController>();
        playerScore = guiController.gameObject.GetComponentInChildren<Score>();
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        playerScore.SaveGame();
        Time.timeScale = 0;
        guiController.GameOverScreen();
        guiController.UpdateBestScoreText();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

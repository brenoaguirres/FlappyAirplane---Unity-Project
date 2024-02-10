using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GUIController : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverScreen;
    [SerializeField]
    public TextMeshProUGUI recordText;
    [SerializeField]
    private Image MedalIcon;
    private Score playerScore;

    [SerializeField]
    private Sprite BrassMedal;
    [SerializeField]
    private Sprite SilverMedal;
    [SerializeField]
    private Sprite GoldMedal;

    private void Start()
    {
        InitializeGUI();
    }

    public void GameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

    public void InitializeGUI()
    {
        gameOverScreen = GetComponentInChildren<Image>(true).gameObject;
        gameOverScreen.SetActive(false);
        playerScore = GetComponentInChildren<Score>(true);
    }

    public void UpdateBestScoreText()
    {
        recordText.text = "Best score : " + PlayerPrefs.GetInt("Best Score");
        UpdateMedal();
    }

    public void UpdateMedal()
    {
        if (PlayerPrefs.GetInt("Best Score") * 0.5 > playerScore.TotalScore)
            MedalIcon.sprite = BrassMedal;
        else if (PlayerPrefs.GetInt("Best Score") > playerScore.TotalScore)
            MedalIcon.sprite = SilverMedal;
        else
            MedalIcon.sprite = GoldMedal;
    }
}

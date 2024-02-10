using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    public int TotalScore { get; private set; }
    private TextMeshProUGUI scoreText;

    public AudioClip scoreSFX;
    private AudioSource scoreAudioSource;
    [SerializeField]
    private UnityEvent onScore;

    private void Awake()
    {
        scoreAudioSource = GetComponent<AudioSource>();
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        TotalScore = 0;
        scoreText.text = TotalScore.ToString();
    }


    public void UpdateScore()
    {
        scoreAudioSource.PlayOneShot(scoreSFX);
        TotalScore++;
        scoreText.text = TotalScore.ToString();
        onScore.Invoke();
    }
    public void SaveGame()
    {
        if (PlayerPrefs.GetInt("Best Score") < TotalScore)
        {
            PlayerPrefs.SetInt("Best Score", TotalScore);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyControl : MonoBehaviour
{
    [SerializeField]
    private float timeForMaxDifficulty;
    private float totalTime;
    public float Difficulty { get; private set; }

    void Update()
    {
        totalTime += Time.deltaTime;
        Difficulty = totalTime / timeForMaxDifficulty;
        Difficulty = Mathf.Min(1, Difficulty);
    }
}

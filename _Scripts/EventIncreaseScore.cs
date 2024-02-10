using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventIncreaseScore : MonoBehaviour
{
    private Vector3 playerPosition;
    private Score score;
    private bool hasScored = false;

    private void Start()
    {
        playerPosition = GameObject.FindObjectOfType<AirplaneStatus>().transform.position;
        score = GameObject.FindObjectOfType<Score>();
    }


    private void Update()
    {
        CheckScore();
    }

    public void CheckScore()
    {
        if (playerPosition.x > transform.position.x && !hasScored)
        {
            score.UpdateScore();
            hasScored = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManagerMultiplayerMode : GameManager
{
    private bool deadPlayer = false;
    private int scoreSinceDeath;
    [SerializeField]
    private int revivalScore = 15;
    protected PlayerScreen[] gamePlayers;
    private GUIDeadController deadScreen;
    protected override void Awake()
    {
        base.Awake();
        gamePlayers = FindObjectsOfType<PlayerScreen>();
    }

    private void Start()
    {
        deadScreen = FindObjectOfType<GUIDeadController>();
    }

    public void TryRevivePlayer()
    {
        if(deadPlayer)
        {
            scoreSinceDeath++;
            deadScreen.UpdateReviveText(revivalScore - scoreSinceDeath);
        }

        if(scoreSinceDeath >= revivalScore)
        {
            RevivePlayer();
            IncreaseReviveDifficulty();
        }
    }

    public void KillPlayer(Camera camera)
    {   
        if (deadPlayer)
        {
            deadScreen.ToggleActive();
            GameOver();
        }
        else
        {
            deadPlayer = true;
            scoreSinceDeath = 0;
            deadScreen.UpdateReviveText(revivalScore);
            deadScreen.ToggleActive(camera);
        }
    }

    private void RevivePlayer()
    {
        deadPlayer = false;
        deadScreen.ToggleActive();
        foreach (var player in gamePlayers)
        {
            player.Activate();
        }
    }

    private void IncreaseReviveDifficulty()
    {
        revivalScore += revivalScore;
    }
}

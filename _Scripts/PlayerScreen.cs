using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerScreen : MonoBehaviour
{
    private CarouselEffect[] scenary;
    private SpawnObstacle obstacleSpawn;
    private AirplaneStatus playerStatus;
    [SerializeField]
    private UnityEvent uponDeactivation;

    private void Start()
    {
        scenary = GetComponentsInChildren<CarouselEffect>();
        obstacleSpawn = GetComponentInChildren<SpawnObstacle>();
        playerStatus = GetComponentInChildren<AirplaneStatus>();
    }

    public void Deactivate()
    {
        foreach(var carousel in scenary)
        {
            carousel.enabled = false;
        }
        obstacleSpawn.Deactivate();
        playerStatus.Deactivate();
        uponDeactivation.Invoke();
    }

    public void Activate()
    {
        foreach (var carousel in scenary)
        {
            carousel.enabled = true;
        }
        obstacleSpawn.Activate();
        
        if (!playerStatus.isAlive)
            playerStatus.Activate();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    //Como gerar obstaculos? -> quebrar em problemas menores.
        //Quando eu quero gerar? -> Tempo
        //Onde eu vou gerar? -> Na posição do meu gerador
        //Como gerar novos obstaculos? -> método de criar
    [SerializeField]
    private GameObject Obstacle;
    private DifficultyControl difficultyControl;

    [SerializeField]
    private float TimeToSpawnEasy = 5;
    [SerializeField]
    private float TimeToSpawnHard = 2;
    private float stopwatch;
    [SerializeField]
    private float OffsetEasy = 0.7f;
    [SerializeField]
    private float OffsetHard = 2;
    private float currentOffset;
    private bool stopped = false;

    private void Awake()
    {
        stopwatch = 1;
    }

    private void Start()
    {
        difficultyControl = GameObject.FindObjectOfType<DifficultyControl>();
    }

    private void Update()
    {
        if (stopped)
            return;

        currentOffset = Mathf.Lerp(OffsetEasy, OffsetHard, difficultyControl.Difficulty);

        stopwatch -= Time.deltaTime;
        if (stopwatch <= 0)
        {
            float randomY = Random.Range(-currentOffset, currentOffset);
            Vector2 randomizedPosition = transform.position + Vector3.up * randomY;

            Instantiate(Obstacle, randomizedPosition, Quaternion.identity);
            stopwatch = Mathf.Lerp(TimeToSpawnEasy, TimeToSpawnHard, difficultyControl.Difficulty);
        }
    }

    public void Deactivate()
    {
        stopped = true;
    }

    public void Activate()
    {
        stopped = false;
    }
}

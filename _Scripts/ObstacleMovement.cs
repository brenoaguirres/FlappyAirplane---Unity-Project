using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField]
    private SharedFloat MoveSpeed;

    private void Update()
    {
        transform.Translate(Vector3.left * MoveSpeed.Value * Time.deltaTime);
    }
}

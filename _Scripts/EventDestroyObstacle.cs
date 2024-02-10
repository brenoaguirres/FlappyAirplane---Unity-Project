using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDestroyObstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Barrier")
        {
            DestroyObstacle();
        }
    }

    private void DestroyObstacle()
    {
        Destroy(gameObject);
    }
}

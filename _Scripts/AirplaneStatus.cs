using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class AirplaneStatus : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D airplane_Rigidbody;
    [SerializeField]
    private UnityEvent onAirplaneCollision;
    [SerializeField]
    private UnityEvent onScore;
    private string obstacleTag = "Obstacle";
    private Vector3 initialPosition;
    [HideInInspector]
    public bool isAlive;
    private AirplaneAnimations airplaneAnimations;

    private void Awake()
    {
        airplane_Rigidbody = GetComponent<Rigidbody2D>();
        airplaneAnimations = GetComponent<AirplaneAnimations>();
        initialPosition = transform.position;
        isAlive = true;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        onAirplaneCollision.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag(obstacleTag))
        {
            onScore.Invoke();
        }
    }

    public void Deactivate()
    {
        isAlive = false;
        airplane_Rigidbody.simulated = false;
        airplaneAnimations.enabled = false;
    }

    public void Activate()
    {
        isAlive = true;
        transform.position = initialPosition;
        airplane_Rigidbody.simulated = true;
        airplaneAnimations.enabled = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneMovement : MonoBehaviour
{
    private Rigidbody2D airplane_Rigidbody;
    [SerializeField]
    private float JumpForce = 10;
    private bool hasJump = false;

    private void Awake()
    {
        airplane_Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (hasJump)
        {
            ImpulseUp();
        }
    }

    public void Jumping()
    {
        hasJump = true;
    }

    public void ImpulseUp()
    {
        airplane_Rigidbody.velocity = Vector2.zero;
        airplane_Rigidbody.AddForce(Vector2.up * JumpForce
            , ForceMode2D.Impulse);
        hasJump = false;
    }
}

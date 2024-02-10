using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneAnimations : MonoBehaviour
{
    private Animator playerAnimator;
    private Rigidbody2D playerRigidbody;
    
    private void Awake()
    {
        playerAnimator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        playerAnimator.SetFloat("YVelocity", playerRigidbody.velocity.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    private AirplaneMovement playerMovement;
    [SerializeField]
    private float timeBetweenJumps = 1.2f;
    [SerializeField]
    private float timeToFirstJump = 0.75f;

    private void Start()
    {
        playerMovement = GetComponent<AirplaneMovement>();
        StartCoroutine(CallImpulse());
    }

    private IEnumerator CallImpulse()
    {
        bool firstLoop = true;
        while (true)
        {
            if (firstLoop)
            {
                yield return new WaitForSeconds(timeToFirstJump);
            }
            firstLoop = false;
            playerMovement.ImpulseUp();
            yield return new WaitForSeconds(timeBetweenJumps);
        }
    }
}

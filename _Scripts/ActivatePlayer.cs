using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivatePlayer : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onAnimationCall;
    public void Activate()
    {
        onAnimationCall.Invoke();
    }
}

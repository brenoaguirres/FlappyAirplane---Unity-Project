using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputController : MonoBehaviour
{
    [SerializeField]
    private KeyCode jumpKey;
    [SerializeField]
    private UnityEvent hasPressedJumpKey;

    private void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            hasPressedJumpKey.Invoke();
        }
    }
}

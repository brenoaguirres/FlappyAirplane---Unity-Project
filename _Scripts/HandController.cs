using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    private SpriteRenderer handSprite;
    private void Awake()
    {
      handSprite = GetComponent<SpriteRenderer>();   
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ToggleHand();
            Destroy(gameObject);
        }
    }

    private void ToggleHand()
    {
        handSprite.enabled = !handSprite.enabled;
    }
}

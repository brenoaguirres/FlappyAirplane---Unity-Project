using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarouselEffect : MonoBehaviour
{
    [SerializeField]
    private SharedFloat MoveSpeed;
    private Vector3 startPosition;
    private float spriteSizeX;
    private float correction = 2;

    private void Awake()
    {
        startPosition = transform.position;
        spriteSizeX = (GetComponent<SpriteRenderer>().size.x * transform.localScale.x) / correction;
    }

    void Update()
    {
        float displacement = Vector3.Distance(startPosition, transform.position);
        if (displacement > spriteSizeX)
        {
            transform.position = startPosition;
        }
        else
        {
            transform.Translate(Vector3.left * MoveSpeed.Value * Time.deltaTime);
        }
    }
}

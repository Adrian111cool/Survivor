using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public float speed;
    int localBase = 1;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.localScale = Vector2.one* (localBase + speed);
            speed += .1f;
        }
        transform.Rotate(Vector3.forward, speed);
        if (Input.GetKey(KeyCode.W))
        {
            transform.localScale = Vector2.one * (localBase - speed);
            speed -= .1f;
            transform.Rotate(Vector3.forward, -speed);
        }

    }
}

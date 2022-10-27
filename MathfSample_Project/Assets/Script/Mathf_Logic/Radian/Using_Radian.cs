using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Using_Radian : MonoBehaviour
{
    private Vector3 position = new(0.0f,0.5f,0.0f);
    private Vector3 velocity = new(0.1f,0.0f,0.0f);

    private float _speed = 0.1f;
    private float angle = 0.0f;

    private void Start()
    {
        transform.position = position;
    }

    private void FixedUpdate()
    {
        position += velocity;

        if((position.x > 5.0f)||(position.x < -5.0f)||        ( position.z > 5.0f)||(position.z < -5.0f))
        {
            position = new(0.0f, 0.5f, 0.0f);
            angle += 2.0f * Mathf.PI / 10.0f;

            if(angle > (2.0f * Mathf.PI)) 
            {
                angle = -2.0f * Mathf.PI;
            }

            velocity.x = _speed * Mathf.Cos(angle);
            velocity.z = _speed * Mathf.Sin(angle);
        }

        transform.position = position;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove2 : MonoBehaviour
{
    private Vector3 position = new Vector3(0.0f, 0.5f, 0.0f);
    private float _velocity = 0.1f;

    private void Start()
    {
        transform.position = position;
    }

    private void FixedUpdate()
    {
        Vector3 velocity = Vector3.zero;

        velocity.x = Input.GetAxis("Horizontal") * _velocity;

        position += velocity;

        if(position.x > 5.0f)
        {
            position.x = 5.0f;
        }
        if(position.x < -5.0f)
        {
            position.x = -5.0f;
        }

        transform.position = position;

    }

}

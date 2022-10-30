using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circul_Motion : MonoBehaviour
{
    //‰~‰^“®
    
    private const float _radius = 5.0f;
    private const float _angle = 2.0f * Mathf.PI / 50.0f;

    private Vector3 position = new Vector3(_radius , 0.5f , 0.0f);

    private Vector3 velocity = new Vector3(0.0f,0.0f,_radius * _angle);

    private void Start()
    {
        transform.position = position;
    }

    private void FixedUpdate()
    {
        position += velocity;
        velocity += -new Vector3(position.x , 0.0f , position.z) * _angle * _angle;

        transform.position = position;
    }
}

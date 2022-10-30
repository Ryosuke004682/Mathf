using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Transform1 : MonoBehaviour
{
    public Renderer rend;
    public Color color = Color.red;

    Vector3 _interval;
    Quaternion _rotation;

    private void Start()
    {
        float X, Y, Z;

        rend = GetComponent<Renderer>();

        X = Mathf.Abs(transform.position.x);
        Y = Mathf.Abs(transform.position.y);
        Z = Mathf.Abs(transform.position.z);

        if((X > Y) && (X > Z))
        {
            color = Color.magenta;
        }
        else
        {
            if(Y > Z)
            {
                color = Color.cyan;
            }
            else
            {
                color = Color.yellow;
            }
        }

        _interval = transform.position;
        _rotation = transform.rotation;

    }
    private void FixedUpdate()
    {
        float angle = 2.0f * Mathf.PI * ((Time.time / 10.0f) % 1);

        Matrix4x4 matrix = Matrix4x4.identity;

        matrix.m11 = Mathf.Cos(angle); matrix.m12 = -Mathf.Sin(angle);
        matrix.m21 = Mathf.Sin(angle); matrix.m22 =  Mathf.Cos(angle);

        transform.position = matrix * _interval;
        transform.rotation = _rotation;

        transform.Rotate(angle * 360.0f / (2.0f * Mathf.PI) , 0.0f , 0.0f , Space.World);

        rend.material.color = color;
        

    }

}

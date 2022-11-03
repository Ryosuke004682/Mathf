using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform2 : MonoBehaviour
{
    public Renderer rend;
    public Color color = Color.red;
    Vector3 position;
    Quaternion rotation;

    private void Start()
    {
        rend = GetComponent<Renderer>();

        float X, Y, Z;

        X = Mathf.Abs(transform.position.x);
        Y = Mathf.Abs(transform.position.y);
        Z = Mathf.Abs(transform.position.z);

        if( (X > Y) && (X > Z) )
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

        position = transform.position;
        rotation = transform.rotation;

    }

    private void FixedUpdate()
    {
        float angle = 2.0f * Mathf.PI * ((Time.time / 10.0f) % 1);

        Matrix4x4 matrix = Matrix4x4.identity;
        matrix.m00 =  Mathf.Cos(angle); 
        matrix.m02 =  Mathf.Sin(angle);

        matrix.m20 = -Mathf.Sin(angle);
        matrix.m22 =  Mathf.Cos(angle);



        transform.position = matrix * position;
        transform.rotation = rotation;
        transform.Rotate(0.0f,angle * 360.0f / (2.0f * Mathf.PI) , 0.0f , Space.World);


        rend.material.color = color;
    }
}

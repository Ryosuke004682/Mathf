using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform4 : MonoBehaviour
{
    //Yé≤âÒì]Ç≥ÇπÇ¬Ç¬ÅAà⁄ìÆé≤Ç≈ì¸óÕÇµÇƒÇ›ÇΩÇ¢

    public Renderer rend;
    public float angle2 = 0.0f;
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

        position = transform.position;
        rotation = transform.rotation;
    }

    private void FixedUpdate()
    {
        float angle = 2.0f * (Time.time / 2.0f);
        Matrix4x4 first_matrix = Matrix4x4.identity;

        first_matrix.m00 =  Mathf.Cos(angle);
        first_matrix.m02 =  Mathf.Sin(angle);
        first_matrix.m20 = -Mathf.Sin(angle);
        first_matrix.m22 =  Mathf.Cos(angle);

        angle2 += Input.GetAxis("Vertical") * 0.05f;
        Matrix4x4 second_matrix = Matrix4x4.identity;

        second_matrix.m11 =  Mathf.Cos(angle2);
        second_matrix.m12 = -Mathf.Sin(angle2);
        second_matrix.m21 =  Mathf.Sin(angle2);
        second_matrix.m22 =  Mathf.Cos(angle2);

        Matrix4x4 matrixTransform = second_matrix * first_matrix;

        transform.position = matrixTransform * position;
        transform.rotation = rotation;

        transform.Rotate(0.0f,angle * 360.0f / (2.0f * Mathf.PI) , 0.0f, Space.World);
        transform.Rotate(angle2 * 360.0f / (2.0f * Mathf.PI) ,0.0f ,0.0f,Space.World);

        rend.material.color = color;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform4 : MonoBehaviour
{
    Vector3 position;
    Matrix4x4 matrix;
    public Renderer rend;
    public Color color = Color.red;

    GameObject obj;

    private void Start()
    {
        float X, Y, Z;

        rend = GetComponent<Renderer>();
        obj = GameObject.Find("Sphere");

        position = transform.position;

        X = Mathf.Abs(transform.position.x);
        Y = Mathf.Abs(transform.position.y);
        Z = Mathf.Abs(transform.position.z);

        if ((X > Y) && (X > Z))
        {
            color = Color.magenta;
        }
        else
        {
            if (Y > Z)
            {
                color = Color.cyan;
            }
            else
            {
                color = Color.yellow;
            }

        }
    }

    private void FixedUpdate()
    {
        Vector3 side, up, forward;

        forward = Vector3.Normalize(obj.transform.position);

        up   = new Vector3(0.0f,0.0f,1.0f);
        side = Vector3.Cross(up , forward);
        side = Vector3.Normalize(side);
        up   = Vector3.Cross(forward,side);


        matrix = Matrix4x4.identity;

        matrix.m00 = side.x; matrix.m01 = up.x; matrix.m02 = forward.x;

        matrix.m10 = side.y; matrix.m11 = up.y; matrix.m12 = forward.y;


        matrix.m20 = side.z; matrix.m21 = up.z; matrix.m22 = forward.z;

        transform.position = matrix * position;
        transform.LookAt(obj.transform.position, new Vector3(0.0f, 0.0f, 1.0f));

        rend.material.color = color;


    }



}

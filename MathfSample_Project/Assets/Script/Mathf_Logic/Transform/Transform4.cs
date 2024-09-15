using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform4 : MonoBehaviour
{
<<<<<<< HEAD
    //YŽ²‰ñ“]‚³‚¹‚Â‚ÂAˆÚ“®Ž²‚Å“ü—Í‚µ‚Ä‚Ý‚½‚¢

    public Renderer rend;
    public float angle2 = 0.0f;
    public Color color = Color.red;

    Vector3 position;
    Quaternion rotation;


    private void Start()
    {
        rend = GetComponent<Renderer>();

        float X, Y, Z;

=======
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

>>>>>>> origin/MyBranch
        X = Mathf.Abs(transform.position.x);
        Y = Mathf.Abs(transform.position.y);
        Z = Mathf.Abs(transform.position.z);

<<<<<<< HEAD
        if((X > Y) && (X > Z))
        {
           color = Color.magenta;
        }
        else
        {
            if(Y > Z)
=======
        if ((X > Y) && (X > Z))
        {
            color = Color.magenta;
        }
        else
        {
            if (Y > Z)
>>>>>>> origin/MyBranch
            {
                color = Color.cyan;
            }
            else
            {
                color = Color.yellow;
            }
<<<<<<< HEAD
        }

        position = transform.position;
        rotation = transform.rotation;
=======

        }
>>>>>>> origin/MyBranch
    }

    private void FixedUpdate()
    {
<<<<<<< HEAD
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

=======
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



>>>>>>> origin/MyBranch
}

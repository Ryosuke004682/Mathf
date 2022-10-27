using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample1 : MonoBehaviour
{
    public Renderer rend;
    public Color colorCube = Color.black;
    private float direction_Angle = 0.0f;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        float X, Y, Z;

        X = Mathf.Abs(transform.position.x);
        Y = Mathf.Abs(transform.position.y);
        Z = Mathf.Abs(transform.position.z);

        if((X > Y) && (X > Z))
        {
            colorCube = Color.magenta;
        }
        else
        {
            if(Y > Z)
            {
                colorCube = Color.cyan;
            }
            else
            {
                colorCube = Color.yellow;
            }
        }
    }

    private void FixedUpdate()
    {
        Quaternion rotation;
        Vector3 axis = Vector3.one;

        direction_Angle = 2.0f * Mathf.PI * Time.deltaTime / 10.0f;
        rotation = Quaternion.AngleAxis(direction_Angle * Mathf.Rad2Deg, axis);


        transform.position = rotation * transform.position;
        transform.rotation = rotation * transform.rotation;
        rend.material.color = colorCube;
    }


}
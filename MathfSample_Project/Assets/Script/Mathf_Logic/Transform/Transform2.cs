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
        float X, Y, Z;

        X = Mathf.Abs(transform.position.x);
        Y = Mathf.Abs(transform.position.y);
        Z = Mathf.Abs(transform.position.z);

        rend = GetComponent<Renderer>();

        if ((X > Y) && (X > Z))
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


    private void Update()
    {
        float angle = 2.0f * Mathf.PI * ((Time.time / 10.0f) % 1);
    }
}

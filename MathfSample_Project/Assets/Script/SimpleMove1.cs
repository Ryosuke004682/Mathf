using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove1 : MonoBehaviour
{
    //X方向5.0と-5.0の間を、0.2のスピードで往復するコード。

    Vector3 position = new Vector3(0.0f, 0.5f, 0.0f);
    Vector3 velocity = new Vector3(0.2f, 0.0f, 0.0f);

    void Start()
    {
        transform.position = position;
    }

    private void FixedUpdate()
    {
        position += velocity;

        if(position.x > 5.0f)
        {
            position.x = 5.0f;
            velocity.x = -velocity.x;
        }
        if(position.x < -5.0f)
        {
            position.x = -5.0f;
            velocity.x = -velocity.x;
        }

        transform.position = position;
    }
}

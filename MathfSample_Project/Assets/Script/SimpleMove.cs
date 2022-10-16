using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    //　X方向に0.2ずつ枚フレーム移動する

    Vector3 position = new Vector3(0.0f, 0.5f, 0.0f);
    Vector3 velocity = new Vector3(0.2f, 0.0f, 0.0f);

    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.blue;

        position = transform.position;
    }

    private void　FixedUpdate()
    {
        position += velocity;
        transform.position = position;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Script : MonoBehaviour
{
    //ボックス＝ミュラー法

    private Vector3 basePosition = new Vector3(0.0f,0.5f,0.0f);

    private Vector3 position;
    private Vector3 velocity;

    private float gravity = -0.003f;

    private void Start()
    {
        float r, angle;

        position = basePosition;
        r = Mathf.Sqrt(-2.0f * Mathf.Log(Random.Range(0.0f,1.0f)));//√2ln(a)
        angle = Random.Range(0.0f, 2.0f * Mathf.PI);//2πb


        velocity = new Vector3(0.2f * r * Mathf.Cos(angle),0.2f,
            0.2f * r * Mathf.Sin(angle));

        transform.position = position;
    }

    private void FixedUpdate()
    {
        position += velocity;
        velocity.y += gravity;

        if(position.y < 0.0f)
        {
            Destroy(gameObject);
        }

        transform.position = position;

    }

}

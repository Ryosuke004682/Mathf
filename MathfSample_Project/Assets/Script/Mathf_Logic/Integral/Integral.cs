using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample3 : MonoBehaviour
{
    private Vector3 position = new (-5.0f , 0.5f , 0.0f);
    private Vector3 velocity = new ( 0.1f , 0.2f , 0.0f);

    private Vector3 basePosition;
    private float gravity = -0.003f;
    private float time = 0.0f;


    /// <summary>
    /// 無限小の時間を加味したよりリアルに近い放物線運動
    /// </summary>
    private void Start()
    {
        basePosition = position;
        
        time = 0.0f; //時間を初期化

        transform.position = position;

    }

    private void FixedUpdate()
    {
        //積分
        basePosition.x = velocity.x * time + position.x;
        basePosition.y = 0.5f * gravity * time * time + velocity.y * time + position.y;

        time++;

        if (basePosition.y < 0.0f)
        {
            time = 0.0f;
        }

        transform.position = basePosition;

    }


}

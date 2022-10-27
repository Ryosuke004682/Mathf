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
    /// –³ŒÀ¬‚ÌŠÔ‚ğ‰Á–¡‚µ‚½‚æ‚èƒŠƒAƒ‹‚É‹ß‚¢•ú•¨ü‰^“®
    /// </summary>
    private void Start()
    {
        basePosition = position;
        
        time = 0.0f; //ŠÔ‚ğ‰Šú‰»

        transform.position = position;

    }

    private void FixedUpdate()
    {
        //Ï•ª
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

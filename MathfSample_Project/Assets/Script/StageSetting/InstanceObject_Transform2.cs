using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceObject_Transform2 : MonoBehaviour
{
    public GameObject cube;
    private const float objCount = 20;
    private const float fInterval = 0.5f;

    public Renderer rend;


    private void Start()
    {
        rend = GetComponent<Renderer>();
        GameObject rootObj = GameObject.Find("Cube");

        Vector3 position = new Vector3(-5.0f,0.0f,0.0f);

        rootObj.transform.position = position;
        rootObj.transform.parent = null;

        GameObject lastGameObj = rootObj;

        for(var i = 1; i <= objCount; i++)
        {
            GameObject gameObj = Instantiate(cube);
            position.x += fInterval;

            gameObj.transform.position = position;
            gameObj.transform.parent = lastGameObj.transform;

            //“r’†

        }

    }
}

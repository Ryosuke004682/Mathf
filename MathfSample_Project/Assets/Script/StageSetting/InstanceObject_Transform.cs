using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceObject_Transform : MonoBehaviour
{
    public GameObject cube;
    private int _count = 0;
    private const int _objectCount = 11;

    private const float _interval = 1.0f;

    private void Start()
    {
        GameObject obj;
        
        for(var instanceObj = 0; instanceObj < _objectCount; instanceObj++)
        {
            obj = Instantiate(cube);
            obj.transform.position = new Vector3((instanceObj - _objectCount / 2) * _interval, 0.0f, 0.0f);

            obj = Instantiate(cube);
            obj.transform.position = new Vector3(0.0f, (instanceObj - _objectCount / 2) * _interval, 0.0f);

            obj = Instantiate(cube);
            obj.transform.position = new Vector3(0.0f,0.0f,(instanceObj - _objectCount / 2) * _interval);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceObject : MonoBehaviour
{
    public GameObject Obj;
    public int _count = 0;

    private void Start()
    {
        
    }
    private void Update()
    {
        if((_count % 5) == 0) 
        {
            Instantiate(Obj);
        }
        _count++;
    }
}

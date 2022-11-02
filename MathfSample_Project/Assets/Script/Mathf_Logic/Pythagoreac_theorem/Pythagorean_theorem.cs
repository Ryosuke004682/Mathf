using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Pythagorean_theorem : MonoBehaviour
{
    //�΂߂̈ړ��������Ȃ�Ȃ��悤��
    //�s�^�S���X�̒藝���g��

    Vector3 position = new Vector3(0.0f,-4.5f,0.0f);

    public float _speed = 0.1f;
    Renderer rend;

    void Start()
    {
        transform.position = position;
       
        rend = GetComponent<Renderer>();
        rend.material.color = Color.red;
    }

    /// <summary>
    /// �s�^�S���X�̒藝�i�O�����̒藝���g���ăx�N�g���𐳋K��������j
    /// </summary>

     void FixedUpdate()
    {
        Vector3 velocity = Vector3.zero;

        velocity.x = Input.GetAxis("Horizontal") * _speed;
        velocity.z = Input.GetAxis("Vertical") * _speed;

        var X = velocity.x * velocity.x;
        var Y = velocity.y * velocity.y;
        var Z = velocity.z * velocity.z;

        //velocity.x = Input.GetAxis("Horizontal") * _speed;
        //velocity.z = Input.GetAxis("Vertical") * _speed;

        var pythagoras = Mathf.Sqrt(X  + Y + Z);
        //var pythagoras = Mathf.Sqrt(velocity.x * velocity.x + velocity.y * velocity.y + velocity.z * velocity.z);

        if (pythagoras > _speed)
        {
            velocity = velocity / pythagoras * _speed;
        }

        position += velocity;

        if (position.x > 5.0f)
            position.x = 5.0f;

        if (position.x < -5.0f)
            position.x = -5.0f;

        if (position.z > 5.0f)
            position.z = 5.0f;

        if (position.z < -5.0f)
            position.z = -5.0f;

        transform.position = position;
    }
}

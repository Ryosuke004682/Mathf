using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform5 : MonoBehaviour
{
    //物体の傾きについて

    private Material material;
    private Mesh mesh;
    private const float floolSize = 10.0f;


    private Vector3 vector1 = new Vector3(floolSize / 2.0f,0.0f,0.0f);
    private Vector3 vector2 = new Vector3(0.0f,0.0f,floolSize / 2.0f);

    private Vector3 groundNomal = new Vector3(0.0f,1.0f,0.0f);
    private float angle = Mathf.PI / 2.0f;


    //頂点
    public Vector3[] position = new Vector3[]
    {
        new(-floolSize / 2.0f , 0.0f ,  floolSize / 2.0f),
        new( floolSize / 2.0f ,0.0f  ,  floolSize / 2.0f),
        new(-floolSize / 2.0f , 0.0f , -floolSize / 2.0f),
        new( floolSize / 2.0f , 0.0f , -floolSize / 2.0f)

    };

    //法線ベクトル
    private Vector3[] nomals = new Vector3[]
    {
        new(0.0f,1.0f,0.0f),
        new(0.0f,1.0f,0.0f),
        new(0.0f,1.0f,0.0f),
        new(0.0f,1.0f,0.0f)
    };

    //ポリゴンデータ
    private int[] indices = new int[] {0,1,2,1,3,2};

    private void Start()
    {
        material = GetComponent<Renderer>().material;
        material.color = Color.red;
        
        mesh = new Mesh();
        mesh.vertices  = position;
        mesh.normals   = nomals;
        mesh.triangles = indices;

        transform.position      = new(0.0f,0.5f,0.0f);
        transform.localPosition = new(2.0f,1.0f,6.0f);
    }

    private void Update()
    {
        position[0] = -vector1 + vector2;
        position[1] = -vector1 - vector2;
        position[2] =  vector1 + vector2;
        position[3] =  vector1 - vector2;

        for (var i = 0; i < 4; i++)
        {
            nomals[i] = groundNomal;
        }
        mesh.vertices = position;
        mesh.normals = nomals;

        Graphics.DrawMesh(mesh , Vector3.zero , Quaternion.identity,material,0);
    }

    private void FixedUpdate()
    {
        vector1 = new(floolSize / 2.0f , 2.0f * Mathf.Sin(Time.time * 2.0f * Mathf.PI / 5.0f) , 0.0f);

        vector2 = new(0.0f, 0.8f * Mathf.Sin(Time.time * 2.0f * Mathf.PI / 7.0f) + 0.7f, floolSize / 2.0f);

        angle += Input.GetAxis("Horizontal") * 0.1f;
        Vector3 up = Vector3.Cross(vector2 , vector1);

    }



}

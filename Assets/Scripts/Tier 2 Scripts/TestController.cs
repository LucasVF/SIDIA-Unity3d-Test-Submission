using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TestController : MonoBehaviour
{
    GameObject pointer;
    // Start is called before the first frame update
    void Start()
    {
        pointer = GameObject.FindGameObjectWithTag("Pointer");
        pointer.SetActive(false);

        MeshFilter filter = GameObject.FindGameObjectWithTag("Image").GetComponent<MeshFilter>();
        Mesh mesh = filter.mesh;
        Vector3[] vertices = mesh.vertices;
        Vector2[] uvs = new Vector2[vertices.Length];
        for (int i = 0; i < uvs.Length; i++)
        {
            uvs[i] = new Vector2(vertices[i].x, vertices[i].z);
        }
        mesh.uv = uvs;

        mesh = GameObject.FindGameObjectWithTag("Image").GetComponent<MeshFilter>().mesh;
        mesh.triangles = mesh.triangles.Reverse().ToArray();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            Teste();
        }
    }

    void Teste()
    {
        pointer.SetActive(true);
    }
}




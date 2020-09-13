using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//Script to know what is the current UV position user is pointing to
//Script was created on the Assumption that camera is inside object where 360 Image will be displayed
public class TestController : MonoBehaviour
{
    GameObject pointer;
    // Start is called before the first frame update
    void Start()
    {
        //Get Player Pointer and deactive it. 
        pointer = GameObject.FindGameObjectWithTag("Pointer");
        pointer.SetActive(false);

        //Get Object where the 360 Image will be displayed and create UV coordinates based on Mesh's vertices
        MeshFilter filter = GameObject.FindGameObjectWithTag("Image").GetComponent<MeshFilter>();
        Mesh mesh = filter.mesh;
        Vector3[] vertices = mesh.vertices;
        Vector2[] uvs = new Vector2[vertices.Length];
        for (int i = 0; i < uvs.Length; i++)
        {
            uvs[i] = convertWorldToUV(vertices[i]);
        }
        mesh.uv = uvs;

        //Revert the object's triangles to display image when camera is inside Object 
        mesh = GameObject.FindGameObjectWithTag("Image").GetComponent<MeshFilter>().mesh;
        mesh.triangles = mesh.triangles.Reverse().ToArray();


    }

    // Update is called once per frame
    void Update()
    {
        //Press this key to activate Pointer Object
        //Activating the Pointer Object will cause a colision with the Object displaying the Image
        if (Input.GetKeyDown("m"))
        {
            Teste();
        }
    }

    void Teste()
    {
        pointer.SetActive(true);
    }

    //Method to Convert World Point to UV Coordinate
    static public Vector2 convertWorldToUV(Vector3 point)
    {
        return new Vector2(point.x,point.z);
    }
}




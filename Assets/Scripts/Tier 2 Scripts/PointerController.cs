using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 pointedAt = collision.GetContact(0).point;

        MeshFilter filter = GameObject.FindGameObjectWithTag("Image").GetComponent<MeshFilter>();
        Mesh mesh = filter.mesh;
        Bounds bounds = mesh.bounds;

        Vector2 uv = new Vector2(pointedAt.x, pointedAt.z);

        Debug.Log(uv);

        gameObject.SetActive(false);
    }

}


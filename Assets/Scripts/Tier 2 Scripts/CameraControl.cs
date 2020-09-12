using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            gameObject.transform.Rotate(10*Vector3.up,Space.Self);
        }
        if (Input.GetKeyDown("a"))
        {
            gameObject.transform.Rotate(10*Vector3.down, Space.Self);
        }
    }
}

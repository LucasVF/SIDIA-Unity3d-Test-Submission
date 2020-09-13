using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to give some control on camera direction
public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
    
        //Makes Camera look to the Right
        if (Input.GetKeyDown("d"))
        {
            gameObject.transform.Rotate(10*Vector3.up,Space.Self);
        }
        //Makes Camera look to the Left
        if (Input.GetKeyDown("a"))
        {
            gameObject.transform.Rotate(10*Vector3.down, Space.Self);
        }
    }
}

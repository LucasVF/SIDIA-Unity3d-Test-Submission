using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to Control the Green Field on  the Start Menu
public class GreenFieldController : MonoBehaviour
{
    //Speed of Sphere Rotation
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate Sphere based on speed 
        gameObject.transform.Rotate(-speed, 0.0f, 0.0f, Space.World);
    }
}

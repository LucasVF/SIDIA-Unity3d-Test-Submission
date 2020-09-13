using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//===============================
//Tier 2 Unity Test - Question 5
//===============================

//Script to display the current UV position user is pointing to, done by collinding with Mesh Collider from image
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
        //Get a point of collision 
        Vector3 pointedAt = collision.GetContact(0).point;

        //Convert point of collision, the same way UV Coordinates were created for Images' Mesh        
        Vector2 uv = TestController.convertWorldToUV(pointedAt);

        //Display UV Coordinate on Console
        Debug.Log(uv);

        //Pointer is deactivated as to collide once again, when activated again
        gameObject.SetActive(false);
    }

}


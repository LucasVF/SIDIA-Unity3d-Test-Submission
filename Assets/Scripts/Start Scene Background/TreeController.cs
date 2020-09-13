using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to create Tree Motion on the Start Screen
public class TreeController : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.003f;
    }

    // Update is called once per frame
    void Update()
    {
        //If Tree has descended past a visible point, it is teleported upward, so it can fall again
        //Collider is turned off as to not collide with Upper Wall
        if (transform.position.y<0.24)
        {
            transform.position = new Vector3(transform.position.x, 2.27f,transform.position.z);
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }
        //Turn on Collider so it can collide with Ball
        if(transform.position.y < 1.64 && transform.position.y >= 0.24)
        {
            gameObject.GetComponent<CapsuleCollider>().enabled = true;
        }
        //Make Tree Fall
        transform.position = new Vector3(transform.position.x, transform.position.y-speed, transform.position.z);
    }
}

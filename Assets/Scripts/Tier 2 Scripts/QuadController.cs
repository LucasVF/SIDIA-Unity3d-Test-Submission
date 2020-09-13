using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to apply desired effect upon a Quad being seen
//Script only works if the only possible collision happens with Field of View Collider
//If more collisions are possible, a verification should be done on collision
public class QuadController : MonoBehaviour
{
    //Variable to indicate whether object is being seen
    public bool beingSeen;
    // Start is called before the first frame update
    void Start()
    {
        //Object Starts not being seen
        beingSeen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //TODO: If colisions with more objects are possible, a verification should be done on colided object to see it is the Field of View Object
    void OnTriggerEnter(Collider other)
    {
        //Upon Colision, Object is being seen
        beingSeen = true;
        Debug.Log("!!!!!!!");
    }
    //TODO: If colisions with more objects are possible, a verification should be done on colided object to see it is the Field of View Object
    void OnTriggerExit(Collider other)
    {
        //Upon exiting Colision, Object has ceased being seen
        beingSeen = false;
        Debug.Log("Incognito mode Activate");
    }
}

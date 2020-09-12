using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadController : MonoBehaviour
{
    public bool beingSeen;
    // Start is called before the first frame update
    void Start()
    {
        beingSeen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        beingSeen = true;
        Debug.Log("!!!!!!!");
    }

    void OnTriggerExit(Collider other)
    {
        beingSeen = false;
        Debug.Log("Incognito mode Activate");
    }
}

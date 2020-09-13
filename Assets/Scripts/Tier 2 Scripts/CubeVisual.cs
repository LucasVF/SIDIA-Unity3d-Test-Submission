using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//===============================
//Tier 2 Unity Test - Question 4
//===============================

//Script to make sure Cube is rendered at desired AxB pixel resolution
public class CubeVisual : MonoBehaviour
{
    private Camera cam;
    // A and B are intended pixel resolution
    public float a=5, b=5;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        //Converting the cubic object position World point to a Screen Point.
        Vector3 screenPos = cam.WorldToScreenPoint(transform.position);

        //Get the right top vertex of the Screen Cube under the representation requirement
        //A and B are divided by 2 because position is on the center of the cubic object
        screenPos.x += a/2;
        screenPos.y += b/2;

        //Convert the vertex screen position to a new World Point Position.
        Vector3 worldPos = cam.ScreenToWorldPoint(screenPos);

        //Get Adjusted scale to be applied on the cubic object
        //Both axis are double the distance from the new World Point Position and the Original Object position.
        float adjusted_x = Vector3.Distance(new Vector3(worldPos.x, 0, 0), new Vector3(transform.position.x, 0, 0))*2;
        float adjusted_y = Vector3.Distance(new Vector3(0, worldPos.y, 0), new Vector3(0, transform.position.y, 0))*2;

        //Scale Cube accordingly 
        transform.localScale = new Vector3(adjusted_x, adjusted_y, transform.localScale.z);
        
    }
}

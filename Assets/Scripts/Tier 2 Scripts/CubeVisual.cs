using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CubeVisual : MonoBehaviour
{
    private Camera cam;
    public float a=5, b=5;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 screenPos = cam.WorldToScreenPoint(transform.position);

        screenPos.x += a/2;
        screenPos.y += b/2;

        Vector3 worldPos = cam.ScreenToWorldPoint(screenPos);

        float adjusted_x = Vector3.Distance(new Vector3(worldPos.x, 0, 0), new Vector3(transform.position.x, 0, 0))*2;
        float adjusted_y = Vector3.Distance(new Vector3(0, worldPos.y, 0), new Vector3(0, transform.position.y, 0))*2;


        transform.localScale = new Vector3(adjusted_x, adjusted_y, transform.localScale.z);
        
    }
}

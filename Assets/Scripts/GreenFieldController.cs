using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenFieldController : MonoBehaviour
{
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(-speed, 0.0f, 0.0f, Space.World);
    }
}

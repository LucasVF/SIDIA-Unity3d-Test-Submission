using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple Script to give the UFO(Ball) on Start Screen some motion
public class BallController : MonoBehaviour
{
    Vector3 pos;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
        speed = 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        //Move UFO up by Speed
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+speed, pos.z);
    }
}

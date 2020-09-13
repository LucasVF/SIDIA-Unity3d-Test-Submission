using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
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
        if (transform.position.y<0.24)
        {
            transform.position = new Vector3(transform.position.x, 2.27f,transform.position.z);
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }

        if(transform.position.y < 1.64 && transform.position.y >= 0.24)
        {
            gameObject.GetComponent<CapsuleCollider>().enabled = true;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y-speed, transform.position.z);
    }
}

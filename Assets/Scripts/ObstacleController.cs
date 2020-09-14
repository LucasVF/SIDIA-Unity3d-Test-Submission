using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to control Obstacles Spawned
public class ObstacleController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // If object has passed Player it should be destroyed
        //Some leeway is given so that object do not disapear on screen
        if (transform.position.z < player.transform.position.z- 1.5f)
        {
            Destroy(gameObject);
        }
    }
}

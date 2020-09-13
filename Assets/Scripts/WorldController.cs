using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to Control the World inside Game Scene
public class WorldController : MonoBehaviour
{
    //Speed of Rotation
    float speed = 0.05f;
    //Aceleration of Rotation
    float aceleration = 0.0001f;
    //Max Speed of Rotation
    float maxSpeed = 0.1f;
    GameState gameState;

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameState>();
    }

    // Update is called once per frame
    void Update()
    {
        //World will only Rotate if Game State is Game Running
        if (gameState.isGameRunning())
        {
            gameObject.transform.Rotate(-speed, 0.0f, 0.0f, Space.World);
            //Increase speed until it hits Max Speed
            if (speed < maxSpeed)
            {
                speed += aceleration;
            }
        }      
        
    }
}

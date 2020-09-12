using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{

    float speed = 0.05f;
    float aceleration = 0.0001f;
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
        if (gameState.isGameRunning())
        {
            gameObject.transform.Rotate(-speed, 0.0f, 0.0f, Space.World);
            if (speed < maxSpeed)
            {
                speed += aceleration;
            }
        }      
        
    }
}

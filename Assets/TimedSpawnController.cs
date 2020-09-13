using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to timely spawn of a GameObject
//Used for Obstacle Spawning
public class TimedSpawnController : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    GameObject world;
    GameState state;
    public Vector3 objectScale;
    // Start is called before the first frame update
    void Start()
    {
        //Call Spawn Method to be invoked periodically 
        world = GameObject.FindGameObjectWithTag("World");
        InvokeRepeating("SpawnObject",spawnTime,spawnDelay);
        state = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameState>();
    }

    // Method that will be called periodically to Spawn Object 
    public void SpawnObject()
    {
        var spawned = Instantiate(spawnee, transform.position, transform.rotation);
        //Spawned Object should be Child of World so it can move according to it.
        spawned.transform.parent = world.transform;
        //Scale can be controlled as diferent GameObjects can be spawned
        spawned.transform.localScale = objectScale;
        //Should not spawn if Game is Running 
        if (stopSpawning || !state.isGameRunning())
        {
            CancelInvoke("SpawnObject");
        }
    }
}

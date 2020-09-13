using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to control Player
public class PlayerController : MonoBehaviour
{
    private int score;
    //Lanes:
    //-1 = Left
    //0 = Center
    //1 = Right
    private int lane;
    GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        //Sets player on starting state
        resetPlayer();
        gameController = GameObject.FindGameObjectWithTag("GameController");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Score is increased by 1 each time method is called
    public void increaseScore()
    {
        this.score++;
    }

    //Method that returns the current Score
    public int getScore()
    {
        return this.score;
    }

    //Method that sets player on starting position, score and lane
    public void resetPlayer()
    {
        this.score = 0;
        this.lane = 0;
        gameObject.transform.position = new Vector3(0f, 0.69f, -8.43f);
    }

    //Method to move player to the Left
    public void goToLeft()
    {
        //Player can only go to the left if not on the left Lane
        if(this.lane != -1)
        {
            goToLane(this.lane - 1);
            Vector3 oldPos = gameObject.transform.position;
            gameObject.transform.position = new Vector3(oldPos.x-0.35f,oldPos.y,oldPos.z);
        }
        
    }

    //Method to move player to the Right
    public void goToRight()
    {
        //Player can only go to the right if not on the Right Lane
        if (this.lane != 1)
        {
            goToLane(this.lane + 1);
            Vector3 oldPos = gameObject.transform.position;
            gameObject.transform.position = new Vector3(oldPos.x + 0.35f, oldPos.y, oldPos.z);
        }
    }

    //Private Method to go to specific Lane based on Parameter
    private void goToLane(int laneN)
    {
        this.lane = laneN;
    }

    //When Player collides with obstacles, the game ends
    private void OnTriggerEnter(Collider other)
    {
        gameController.GetComponent<GameController>().endGame();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    private int score;
    private int lane;
    GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        resetPlayer();
        gameController = GameObject.FindGameObjectWithTag("GameController");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseScore()
    {
        this.score++;
    }

    public int getScore()
    {
        return this.score;
    }

    public void resetPlayer()
    {
        this.score = 0;
        this.lane = 0;
        gameObject.transform.position = new Vector3(0f, 0.69f, -8.43f);
    }

    public void goToLeft()
    {
        if(this.lane != -1)
        {
            goToLane(this.lane - 1);
            Vector3 oldPos = gameObject.transform.position;
            gameObject.transform.position = new Vector3(oldPos.x-0.35f,oldPos.y,oldPos.z);
        }
        
    }

    public void goToRight()
    {
        if (this.lane != 1)
        {
            goToLane(this.lane + 1);
            Vector3 oldPos = gameObject.transform.position;
            gameObject.transform.position = new Vector3(oldPos.x + 0.35f, oldPos.y, oldPos.z);
        }
    }
    private void goToLane(int laneN)
    {
        this.lane = laneN;
    }

    private void OnTriggerEnter(Collider other)
    {
        gameController.GetComponent<GameController>().endGame();
    }
}

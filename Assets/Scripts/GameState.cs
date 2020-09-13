using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class dictating Game State 
public class GameState : MonoBehaviour
{
    //Game has 3 states, indicated by the variable below: 
    //1-Game Running
    //2-Game Paused
    //3-Game Ended
    private int state;
    private GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        setState(0);
        gameController = gameObject.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Returns which State the game is currently in 
    public int getState()
    {
        return this.state;
    }

    // Sets the Game as State Game Running
    public void startGame()
    {
        setState(0);
    }

    // Sets the Game as Game Paused
    public void pauseGame()
    {
        //Game can only pause if it was Running before
        if (isGameRunning())
        {
            setState(1);
            Debug.Log("Paused Game");
            gameController.updateDisplays();
        }

    }

    //Sets the Game as Game Ended
    public void endGame()
    {
        setState(2);
        gameController.updateDisplays();
    }

    //Checks if Game is Paused
    public bool isPaused()
    {
        return this.state == 1;
    }

    //Checks if Game is Running
    public bool isGameRunning()
    {
        return this.state == 0;
    }

    //Checks if Game is Ended
    public bool isResult()
    {
        return this.state == 2;
    }

    //Sets the State of the Game
    private void setState(int i)
    {
        this.state = i;
    }
}

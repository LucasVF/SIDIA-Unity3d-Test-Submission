using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
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

    public int getState()
    {
        return this.state;
    }

    public void startGame()
    {
        setState(0);
    }

    public void pauseGame()
    {
        if (isGameRunning())
        {
            setState(1);
            Debug.Log("Paused Game");
            gameController.updateDisplays();
        }
        
    }

    public void endGame()
    {
        setState(2);
        gameController.updateDisplays();
    }

    public bool isPaused()
    {
        return this.state == 1;
    }

    public bool isGameRunning()
    {
        return this.state == 0;
    }

    public bool isResult()
    {
        return this.state == 2;
    }

    private void setState(int i)
    {
        this.state = i;
    }
}

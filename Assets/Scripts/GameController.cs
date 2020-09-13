using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Main Script to Control the Game
public class GameController : MonoBehaviour
{
    SceneController sceneController;
    GameObject[] pauseDisplay, resultDisplay, gameDisplay;
    GameState gameState;
    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        //Start Game Scene by getting all main Game Components
        sceneController = gameObject.GetComponent<SceneController>();
        gameState = gameObject.GetComponent<GameState>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        pauseDisplay = GameObject.FindGameObjectsWithTag("PauseDisplay");
        resultDisplay = GameObject.FindGameObjectsWithTag("ResultDisplay");
        gameDisplay = GameObject.FindGameObjectsWithTag("GameDisplay");

        startNewGame();
    }

    // Update is called once per frame
    void Update()
    {        
        //Score is only increased when Game is Running
        //Score is increased each frame
        if (gameState.isGameRunning())
        {
            player.increaseScore();
        }
    }

    //Method to update every the display of every component that can alter their display state
    public void updateDisplays()
    {
        updatePause();
        updateResult();
        updateGame();
    }
    //Method to update every the display of every component that should be displayed when Game is Paused
    private void updatePause()
    {
        foreach (GameObject pauseElement in pauseDisplay)
        {
            pauseElement.SetActive(gameState.isPaused());
            if(pauseElement.name == "PauseButton")
            {
                pauseElement.SetActive(!gameState.isPaused());
                pauseElement.GetComponent<Image>().enabled = !gameState.isPaused();
            }
        }
    }
    //Method to update every the display of every component that should be displayed when Game has ended
    private void updateResult()
    {
        foreach (GameObject resultElement in resultDisplay)
        {
            resultElement.SetActive(gameState.isResult());
            if (resultElement.name == "ResultScore")
            {
                resultElement.GetComponent<Text>().text = "Score\n\n"+player.getScore();
            }
        }
    }

    //Method to update every the display of every component that should be displayed when Game is Running
    private void updateGame()
    {
        foreach (GameObject gameDisplayElement in gameDisplay)
        {
            gameDisplayElement.SetActive(gameState.isGameRunning());
        }
    }

    //Method to call when game has ended
    public void endGame()
    {
        Debug.Log("Result Screen");
        gameState.endGame();
    }

    //Method to set Game Components to their starting value
    public void startNewGame()
    {
        gameState.startGame();
        Debug.Log("Starting New Game");
        player.resetPlayer();
        updateDisplays();
    }

    //Method to call when player wants to Unpause the game
    public void keepPlaying()
    {
        Debug.Log("UnPaused Game");
        gameState.startGame();
        updateDisplays();
    }
}

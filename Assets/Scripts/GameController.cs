using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    SceneController sceneController;
    GameObject[] pauseDisplay, resultDisplay, gameDisplay;
    GameState gameState;
    PlayerModel player;
    // Start is called before the first frame update
    void Start()
    {
        sceneController = gameObject.GetComponent<SceneController>();
        gameState = gameObject.GetComponent<GameState>();

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerModel>();

        pauseDisplay = GameObject.FindGameObjectsWithTag("PauseDisplay");
        resultDisplay = GameObject.FindGameObjectsWithTag("ResultDisplay");
        gameDisplay = GameObject.FindGameObjectsWithTag("GameDisplay");
        startNewGame();
    }

    // Update is called once per frame
    void Update()
    {
        int initialState = gameState.getState();

        if (Input.GetKeyDown("escape"))
        {
            sceneController.ExitGame();
        }

        if(Input.GetKeyDown("space"))
        {          

            if (initialState == 0)
            {
                
                gameState.pauseGame();
            }

            updateDisplays();
        }

        if (Input.GetKeyDown("r"))
        {

            if (initialState == 0)
            {
                endGame();
            }

            updateDisplays();
        }

        if (gameState.isGameRunning())
        {
            player.increaseScore();
        }
    }

    public void updateDisplays()
    {
        updatePause();
        updateResult();
        updateGame();
    }

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

    private void updateGame()
    {
        foreach (GameObject gameDisplayElement in gameDisplay)
        {
            gameDisplayElement.SetActive(gameState.isGameRunning());
        }
    }

    public void endGame()
    {
        Debug.Log("Result Screen");
        gameState.endGame();
    }

    public void startNewGame()
    {
        gameState.startGame();
        Debug.Log("Starting New Game");
        player.resetPlayer();
        updateDisplays();
    }

    public void keepPlaying()
    {
        Debug.Log("UnPaused Game");
        gameState.startGame();
        updateDisplays();
    }
}

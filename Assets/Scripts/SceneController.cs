using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Script to control Scene Management on the Game
public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If player hits ESC key, the game will close
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    // Method to go to Game Scene
    public void GoToGame()
    {
        GoToScene("GameScene");
    }

    //Method to go to Start Menu Scene
    public void GoToStartMenu()
    {
        GoToScene("StartScene");
    }

    // Private Method to go to a Scene based on Scene's Name
    private void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //Method to Quit the game
    public void ExitGame()
    {
        Application.Quit();
    }
}

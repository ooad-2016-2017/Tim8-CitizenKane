using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public void startGame()
    {
        SceneManager.LoadScene("ShootingScene");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}

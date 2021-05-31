using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Lose()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }

}

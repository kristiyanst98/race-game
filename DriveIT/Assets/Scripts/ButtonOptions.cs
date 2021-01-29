using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour
{
  
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Track01()
    {
        SceneManager.LoadScene(3);
    }
    public void Track02()
    {
        SceneManager.LoadScene(4);
    }
    public void PlayCredits()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

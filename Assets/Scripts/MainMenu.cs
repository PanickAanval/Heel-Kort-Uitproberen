using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Cursor.lockState = CursorLockMode.None;
    }

    public void Quit()
    {
        Debug.Log("Doei");
        Application.Quit();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void ToPuzzle ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ToEnd()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       Cursor.lockState = CursorLockMode.None;
    }
}
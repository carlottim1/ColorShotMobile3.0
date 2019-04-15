using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("ColorShot");
    }
    public void LoadInstructions()
    {
        SceneManager.LoadScene("I");
    }
    public void LoadControls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("menu");
    }
}

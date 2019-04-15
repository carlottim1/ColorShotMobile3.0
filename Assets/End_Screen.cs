using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End_Screen : MonoBehaviour
{
    public Text scoreText;
    public string display = "";
    public int score;
    public void Menu()

    {
       SceneManager.LoadScene("menu");    
    }
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Update() {
        score = PlayerPrefs.GetInt("HIGHSCORE");
        display = score.ToString();
        scoreText.text = "High Score: " + display;
        Debug.Log(display);
    }
}

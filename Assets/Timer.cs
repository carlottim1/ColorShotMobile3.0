using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    public bool finish = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        float t = Time.time - startTime;
        float minuteCheck = (t / 60);
        string minutes = (t / 60).ToString();
        string seconds = ((int)t % 60).ToString();
        timerText.text = "Time: " + seconds;
        if (minuteCheck >= 1)
        {
            finish = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


    }
}

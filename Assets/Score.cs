using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text scoreText;
    private float minusScore = -15f;
    private float plusScore = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string displayScore = "0";

        /*    if (touchingPlatform && Ball.materials.element_0 == Color(0, 0, 0))
            {
                totalScore = totalScore + plusScore;
                displayScore = totalScore.ToString();
            }

            if (touchingPlatform && Ball.materials.element_0 != Color(0, 0, 0))
            {
                totalScore = totalScore + minusScore;
                displayScore = totalScore.ToString();
            }*/

        //scoreText.text = "Score: " + ToString(PlayerPrefs.GetInt("Final Score"));

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "YellowR1" || col.gameObject.name == "YellowR2" || col.gameObject.name == "YellowR3")
        {
            Debug.Log("Collision Detected");
        }
    }

}

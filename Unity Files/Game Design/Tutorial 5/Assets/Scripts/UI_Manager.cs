using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;
    public static float score;
    public static int lives;
	// Start is called before the first frame update
	void Start()
    {
        score = 0;
        lives = 3;
    }

    // Update is called once per frame;
   void Update()
    {
        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
        Scene scene = SceneManager.GetActiveScene();

        // Check if the name of the current Active Scene is your first Scene.
        if (scene.name == "Game")
            {
            
            if (lives == 0)
                {
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("Game Over");
                }

            }
    }
}

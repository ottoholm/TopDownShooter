using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public GameObject gameOverCreen;

    int lives = 3;

    private void OnTriggerEnter(Collider other)
    {
        //Turn off life hearts images
        if (lives == 3)
        {
            lives--;
            heart1.SetActive(false);
        }
        else if (lives == 2)
        {
            lives--;
            heart2.SetActive(false);
        }

        // deactivates last heart, Stops time and activates gameOverScreen
        else if (lives == 1)
        {
            lives--;
            heart3.SetActive(false);

            Debug.Log("GAME OVER!");
            Time.timeScale = 0f;
            gameOverCreen.SetActive(true);
        }
    }
}

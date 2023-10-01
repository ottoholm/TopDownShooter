using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int scoreValue = 0;

    void Update()
    {
        scoreText.text = scoreValue.ToString();
    }
}

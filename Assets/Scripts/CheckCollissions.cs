using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckCollissions : MonoBehaviour
{

    private Score scoreScript;

    void Start()
    {
        scoreScript = GameObject.Find("ScoreBoard").GetComponent<Score>();
    }
    public void OnTriggerEnter(Collider other)
    {
        scoreScript.scoreValue++;
        Debug.Log("J�b� t�rm�s t�ll�seen " + other.name );
        // Destroy both objects
        Destroy(other.gameObject); // other (food)
        Destroy(gameObject);      // ourselves (animal)
    }
    
}

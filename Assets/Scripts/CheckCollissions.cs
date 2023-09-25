using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollissions : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Jäbä törmäs tälläseen jutuskaan " + other.name);

        // Destroy both objects
        Destroy(other.gameObject); // other (food)
        Destroy(gameObject);      // ourselves (animal)
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

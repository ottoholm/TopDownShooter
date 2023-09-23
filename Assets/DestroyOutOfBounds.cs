using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //tuhotaan objekti jos z-akselin sijainti < -20 tai >40 
        if (transform.position.z < -20)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > 40)
        {
            Destroy(gameObject);
        }
    }
}

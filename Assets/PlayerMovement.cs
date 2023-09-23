using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 0f;
    public float playerInput;
    public float movementLimit;

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        //havaitaan käyttäjän sivuttais liike näppäimet ja liikkuu tasasesti sivuille
        playerInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveSpeed * playerInput * Time.deltaTime);

        //rajataan pelaajan liike x-akselilla
        if (transform.position.x < -movementLimit)
        {
            transform.position = new Vector3(-movementLimit, transform.position.y, transform.position.z);
        }

        else if (transform.position.x > movementLimit)
        {
            transform.position = new Vector3 (movementLimit, transform.position.y, transform.position.z);
        }
        
    }
}

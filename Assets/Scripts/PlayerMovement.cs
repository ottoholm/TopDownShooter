using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 0f;
    public float playerInput;
    public float movementLimit;

    public GameObject food;

    void Start()
    {
        
    }

    
    void Update()
    {
        //havaitaan käyttäjän sivuttais liike näppäimet ja liikkuu tasasesti sivuille
        playerInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveSpeed * playerInput * Time.deltaTime);


        // shoots food
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (food != null)
            {

                Instantiate(food, transform.position + Vector3.up, food.transform.rotation);
            }
        }

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

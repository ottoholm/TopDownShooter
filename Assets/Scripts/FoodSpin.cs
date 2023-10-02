using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpin : MonoBehaviour
{
    //paljonko pyörii
    public float xAngle, yAngle, zAngle;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        //paska pyörii
        transform.Rotate(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime);
    }
}

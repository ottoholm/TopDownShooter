using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 1f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        //liikku tasasesti eteenp�in
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

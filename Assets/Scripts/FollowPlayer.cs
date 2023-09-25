using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        //kameran sijainti sama kun pelaajan + jotain
        transform.position = player.transform.position + new Vector3 (0, 50, 12);
    }
}

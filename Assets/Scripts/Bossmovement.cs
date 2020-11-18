using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossmovement : MonoBehaviour
{

    public float movementSpeed = 1f;
    public Vector2 moveVector;
    
    void Start()
    {
        transform.position = new Vector2(0f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //move to random position then stop
        //shoot beam for a small period of time
        //move again

        //after taking certain amount of damage retreat off screen and disappear

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddle : MonoBehaviour

{
    public float speed = 10f;
   private Rigidbody2D rb2d;
   public float yBorder = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
         rb2d = GetComponent<Rigidbody2D>(); //declare value of the variable 
    }

    // Update is called once per frame
    void Update()
    {
            var velocity = rb2d.velocity; //creates and declare variables for velocity
    
    //control the paddle
    if (Input.GetKey(KeyCode.W)  && transform.position.y <= yBorder)
    { 
velocity.y = speed; //move the speed 
Debug.Log("W");
    }
    else if (Input.GetKey(KeyCode.A) && transform.position.y >= -yBorder)
    {
        velocity.y = -speed; //move the speed down
        Debug.Log("A");
    }
    else { //otherwise
velocity.y = 0; //dont move
    }
rb2d.velocity = velocity;
    }
}

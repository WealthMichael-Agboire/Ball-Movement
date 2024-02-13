 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movements : MonoBehaviour
{
 //varibles for game
 public float xspeed = 0.5f; //variable for the movement on the x axis
  public float xBorder = 7.5f;
    public float yspeed = 0.5f;
    public float yBorder = 7.5f;
    public bool yMove = true;
    public bool xMove = true;

    // Start is called before the first frame update
    void Start()
    {
        xspeed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (xMove == true) {
       transform.position = new Vector2 (transform.position.x + xspeed, transform.position.y);
        }
        if (transform.position.x>=xBorder) {
            xMove=false;
    }
        if (yMove == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + yspeed);
        }
        if (transform.position.y >= yBorder)
        {
            yMove = false;
        }

    }
}
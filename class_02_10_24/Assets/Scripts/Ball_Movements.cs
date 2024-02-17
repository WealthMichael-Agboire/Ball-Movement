 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movements : MonoBehaviour
{
    //varibles for game
    public float xspeed = 0.01f; //variable for the movement on the x axis
    public float xBorder = 7.5f;
    public float yspeed = 0.01f;
    public float yBorder = 2.5f;
  public float xBorder2 = -7.5f;
  public float yBorder2 = -2.5f;
   public bool yMove = true;
    public bool xMove = true;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xspeed, transform.position.y);
        }
        if (transform.position.x >= xBorder)
        {
            transform.position = new Vector2(transform.position.x - xspeed, transform.position.y);
        }
        if (transform.position.x >= xBorder2) 
        {
            xMove = false
        }


        if (yMove == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + yspeed);
        }
        if (transform.position.y >= yBorder)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - yspeed);
        }
        if (transform.position.y >= yBorder2)
        {
           yMove = false
        }

   
       
    }
}

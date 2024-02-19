using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBallMovement : MonoBehaviour
{


public float xspeed = 0.01f; //variable for the movement on the x axis
    public float xBorder = 10.9f;
    public float yspeed = 0.01f;
    public float yBorder = 4.5f;
   public bool yMove = true;
    public bool xMove = true;




    // Start is called before the first frame update
    void Start()
    {
         
    }


    // Update is called once per frame
    void Update()
    {
        if (xMove == true) {
            transform.position = new Vector2(transform.position.x + xspeed, transform.position.y);
        }
        else {
             transform.position = new Vector2(transform.position.x - xspeed, transform.position.y);
        }
        if (transform.position.x >= xBorder){
            xMove = false;
        }
        else if (transform.position.x <= -xBorder)
        {
            xMove=true;
        }

        if (yMove == true) {
            transform.position = new Vector2(transform.position.x, transform.position.y + yspeed);
        }
        else {
             transform.position = new Vector2(transform.position.x, transform.position.y - yspeed);
        }
        if (transform.position.y >= yBorder){
            yMove = false;
        }
        else if (transform.position.y <= -yBorder)
        {
            yMove=true;
        }

}
void OnCollisionEnter2D(Collision2D collision) {
    if (collision.collider.CompareTag ("RPlayer")) 
    { 
        Debug.Log("hit");
    
    if (xMove == true)
    {
        xMove = false;
    }
    else if (xMove == false)
    {
        xMove = true;
    }
    }
}
}
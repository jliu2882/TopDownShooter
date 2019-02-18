using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    void Start()
    {

    }
    
    void Update()
    {
        if (Constants.gameOver)
        {

        }
        else
        {
            //takes wasd and the arrow keys and moves the player based on command; if the player moves out of bounds it moves it back
            //TODO make code more efficient
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + Constants.movespeed);
                if (outOfBounds())
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - Constants.movespeed);
                }
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - Constants.movespeed);
                if (outOfBounds())
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + Constants.movespeed);
                }
            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(transform.position.x + Constants.movespeed, transform.position.y);
                if (outOfBounds())
                {
                    transform.position = new Vector3(transform.position.x - Constants.movespeed, transform.position.y);
                }
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector3(transform.position.x - Constants.movespeed, transform.position.y);
                if (outOfBounds())
                {
                    transform.position = new Vector3(transform.position.x + Constants.movespeed, transform.position.y);
                }
            }
        }
    }
    //Takes the object and finds the point of the screen it is on; test to see if it is inside the boundaries of the screen
    System.Boolean outOfBounds()
    {
        Vector3 pointOnScreen = Camera.main.WorldToScreenPoint(gameObject.GetComponentInChildren<Renderer>().bounds.center);
        
        if ((pointOnScreen.x < 0) || (pointOnScreen.x > Screen.width) ||
                (pointOnScreen.y < 0) || (pointOnScreen.y > Screen.height))
        {
            return true;
        }

        return false;
    }
}
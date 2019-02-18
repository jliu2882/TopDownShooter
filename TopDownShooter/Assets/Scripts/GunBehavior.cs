using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehavior : MonoBehaviour
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
            //points gun to mouse
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);
            float angle = AngleBetweenPoints(transform.position, mouseWorldPosition);
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
            //if the player mouse button is held down, the gun shoots
            //TODO implement a "cooldown" for the gun
            if (Input.GetMouseButton(0))
            {
                shoot();
            }
        }
    }
    //used to determine angle between two points
    float AngleBetweenPoints(Vector2 a, Vector2 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
    //WIP
    void shoot()
    {
        int x = 0;
    }
}

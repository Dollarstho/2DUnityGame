using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Movements Settings")]
    public float speed = 5f;
    public float velocity = 1f;

    public Rigidbody2D rb;


    void Update()
    {
        OnMovement();
        OnRun();  
    }

    public void OnRun()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocity = speed * 2f;
        }
        else
        {
            velocity = speed;
        }

    }

    public void OnMovement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2 (transform.position.x, transform.position.y + velocity * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2 (transform.position.x, transform.position.y - velocity * Time.deltaTime);
        }


        if(Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2 (transform.position.x + velocity * Time.deltaTime, transform.position.y);
        }
       
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2 (transform.position.x - velocity * Time.deltaTime, transform.position.y);
        }
    }
}

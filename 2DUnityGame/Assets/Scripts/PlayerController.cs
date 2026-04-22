using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 5f;
    public float runMultiplier = 2f;

    private Rigidbody2D rb;
    private Vector2 movement;
    private float currentSpeed;

    void Awake()
         {
                rb = GetComponent<Rigidbody2D>();
         }

        void Update()
        {
                movement.x = Input.GetAxisRaw("Horizontal");
                movement.y = Input.GetAxisRaw("Vertical");

                currentSpeed = Input.GetKey(KeyCode.LeftShift) ? speed * runMultiplier : speed;

    }

        void FixedUpdate()
        {
                rb.velocity = movement.normalized * currentSpeed;
        }
    }

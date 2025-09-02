using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputAction moveAction;
    public InputAction jumpAction;
    public Transform playerBody;
    public Transform ground;
    public LayerMask groundMask;
    public Rigidbody2D rb;
    public float moveSpeed;
    public float jumpHeight;
    public float fireRate;

    void Start()
    {
        moveAction.Enable();
        jumpAction.Enable();
    }

    void Update()
    {
        bool groundCheck = Physics2D.OverlapBox(ground.position, new Vector2(0.85f, 0.1f), 0f, groundMask);


        float moveInput = moveAction.ReadValue<float>();
        float jumpInput = jumpAction.ReadValue<float>();


        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (groundCheck == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpInput * jumpHeight);
        }
    }

}

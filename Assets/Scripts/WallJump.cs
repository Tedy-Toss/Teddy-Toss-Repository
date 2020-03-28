﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : MonoBehaviour
{
    public bool allowedToJump;
    public bool jump;

    public float jumpForce = 10f;

    public Rigidbody2D playerBody;

    // Start is called before the first frame update
    void Start()
    {
        allowedToJump = false;
        jump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && allowedToJump && jump == true)
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpForce);
            allowedToJump = false;
            jump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall" && jump == true)
        {
            allowedToJump = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            allowedToJump = false;
            jump = true;
        }
    }
}

//test

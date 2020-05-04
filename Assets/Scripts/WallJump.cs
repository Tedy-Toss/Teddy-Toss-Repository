using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : MonoBehaviour
{
    public bool allowedToJump;
    public bool jump;
    public bool onGround;

    public float jumpForce = 10f;

    public Rigidbody2D playerBody;

    // Start is called before the first frame update
    void Start()
    {
        allowedToJump = false;
        jump = true;
        onGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && allowedToJump && jump == true && onGround == false)
        {
            Debug.Log("jump");
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpForce);
            allowedToJump = false;
            jump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall" && jump == true)
        {
            jump = true;
            allowedToJump = true;
            Debug.Log("im on wall");
        }

        if (collision.gameObject.tag == "ground")
        {
            onGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            allowedToJump = false;
            jump = true;
            Debug.Log("why am i here");
        }

        if (collision.gameObject.tag == "ground")
        {
            onGround = false;
        }
    }
    
}

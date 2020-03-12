using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : MonoBehaviour
{
    public bool allowedToJump;

    public float jumpForce = 10f;

    public Rigidbody2D playerBody;

    // Start is called before the first frame update
    void Start()
    {
        allowedToJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && allowedToJump)
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpForce);
            allowedToJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            allowedToJump = true;
        }

        if (collision.gameObject.tag != "wall")
        {
            allowedToJump = false;
        }
    }
}

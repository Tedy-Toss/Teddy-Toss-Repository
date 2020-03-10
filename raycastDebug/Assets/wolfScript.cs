using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfScript : MonoBehaviour
{
    public GameObject Line;
    public GameObject LineTwo;
    public GameObject LineThree;
    public GameObject LineFour;

    public int speed = 8;
    // Start is called before the first frame update
    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        Line = GameObject.Find("Line");
        LineTwo = GameObject.Find("LineTwo");
        LineThree = GameObject.Find("LineThree");
        LineFour = GameObject.Find("LineFour");
    }



    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }




        // Cast a ray 
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, Mathf.Infinity);
        RaycastHit2D hitDown = Physics2D.Raycast(transform.position, -Vector2.up, Mathf.Infinity);
        RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector2.right, Mathf.Infinity);
        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, -Vector2.right, Mathf.Infinity);

        Debug.DrawRay(transform.position, Vector2.up);

        // If it hits something...
        bool hitSomething = false;
        if (hitRight.collider != null)
        {
            if (hitRight.collider.name == "SquareRight")
            {
                Line.SetActive(true);
                hitSomething = true;
            }
        }
        if (hit.collider != null)
        {
            if (hit.collider.name == "SquareTop")
            {
                LineTwo.SetActive(true);
                hitSomething = true;
            }
        }
        if (hitLeft.collider != null)
        {
            if (hitLeft.collider.name == "SquareLeft")
            {
                LineThree.SetActive(true);
                hitSomething = true;
            }
        }
        if (hitDown.collider != null)
        {
            if (hitDown.collider.name == "SquareDown")
            {
                LineFour.SetActive(true);
                hitSomething = true;
            }

        }
        if(hitSomething == false)
        {
            Line.SetActive(false);
            LineTwo.SetActive(false);
            LineThree.SetActive(false);
            LineFour.SetActive(false);
        }

    }
}

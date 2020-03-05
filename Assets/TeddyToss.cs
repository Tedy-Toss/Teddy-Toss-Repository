using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyToss : MonoBehaviour
{
    Vector2 startPos;
    Vector2 launchVector;
    public float force = 100;

    private CharacterController2D airMove;

    private bool isAir = false;

    // Start is called before the first frame update
    void Start()
    {
        airMove = this.GetComponent<CharacterController2D>();
    }

    private void Update()
    {
        startPos = transform.position;
    }


    void OnMouseUp()
    {
        if (isAir == false)
        {
            // Disable isKinematic
            GetComponent<Rigidbody2D>().isKinematic = false;

            // Add the Force
            Vector2 dir = startPos - launchVector;
            GetComponent<Rigidbody2D>().AddForce(dir * force);
            isAir = true;
        }
    }

    void OnMouseDrag()
    {
        if (isAir == false)
        {
            // Convert mouse position to world position
            Vector2 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Keep it in a certain radius
            float radius = 1.8f;
            Vector2 dir = p - startPos;
            if (dir.sqrMagnitude > radius)
                dir = dir.normalized * radius;

            // Set the Position
            launchVector = startPos + dir;

            airMove.m_AirControl = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            airMove.m_AirControl = true;
            isAir = false;
        }
    }
}

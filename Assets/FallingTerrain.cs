using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTerrain : MonoBehaviour
{
    public float blockSpeed = -10f;
    private Rigidbody2D FallingBlock;
    

    private void Awake()
    {
        FallingBlock = GetComponent<Rigidbody2D>();
    }
   

    void OnCollisionEnter(Collision collision)
    {
        //MovingBlock.AddForce(transform.up * blockSpeed * Time.fixedDeltaTime);

        if (collision.gameObject.tag == "player")
        {

            FallingBlock.AddForce(transform.up * blockSpeed);
        }
    }
}
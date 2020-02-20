using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTerrain : MonoBehaviour
{
    public float blockSpeed = 1f;
    private Rigidbody2D MovingBlock;
    public float Track = 0f;

    private void Awake()
    {
        MovingBlock = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //MovingBlock.AddForce(transform.up * blockSpeed * Time.fixedDeltaTime);

        MovingBlock.AddForce(transform.up * -blockSpeed * Time.fixedDeltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTerrain : MonoBehaviour
{
    public float Speed;

    public Transform sensorPosition;
    public Transform StartPosition, EndPosition;
    public Transform player;

    Vector3 nextPos;

    void Start()
    {
        nextPos = this.transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            nextPos = EndPosition.position;
           Debug.Log("hey");
        }
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextPos, Speed * Time.deltaTime);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(StartPosition.position, EndPosition.position);
    }
}

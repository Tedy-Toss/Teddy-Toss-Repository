using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTerrain : MonoBehaviour
{
    public float Speed;

    public Transform startPos;
    public Transform StartPosition, EndPosition;
    public Transform player;

    Vector3 nextPos;

    void Start()
    {
        nextPos = StartPosition.position;
    }

    void Update()
    {
        if (startPos.position == player.position)
        {
            nextPos = EndPosition.position;
           Debug.Log("hey");
        }
              
        transform.position = Vector3.MoveTowards(transform.position, nextPos, Speed * Time.deltaTime);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(StartPosition.position, EndPosition.position);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTerrain : MonoBehaviour
{
    public float Speed;

    public Transform startPos;
    public Transform StartPosition, EndPosition;
    

    Vector3 nextPos;

    void Start()
    {
        nextPos = startPos.position;
    }

    void Update()
    {
        if (transform.position == StartPosition.position)
        {
            nextPos = EndPosition.position;
           // Debug.Log("hey");
        }

        if (transform.position == EndPosition.position)
        {
            nextPos = StartPosition.position;
            //Debug.Log("hi");
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, Speed * Time.deltaTime);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(StartPosition.position, EndPosition.position);
    }
}
  

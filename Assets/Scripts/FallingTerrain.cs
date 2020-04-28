using System.Collections;
using System.Collections.Generic;
using UnityEngine;  //unity initlization stuff 
using UnityEngine.Events;

public class FallingTerrain : MonoBehaviour
{
    public float Speed; // controls speed with a float 

    
    public Transform StartPosition, EndPosition;  // saves the current position of two elements 
    

    Vector3 nextPos; // makes the nextPos var a vector 3

    GameObject deathReset;  //creates game object named deathReset
    deathRespawn isded; //makes the script deathRespawn and calls it isded  
        
void Start()
    {
        nextPos = this.transform.position; //makes sure the block goes here on start 

        deathReset = GameObject.FindWithTag("Player"); // makes the things below possible by linking them propely 
        isded = deathReset.GetComponent<deathRespawn>();  //attaches deathResoawn script to isded
        isded.isdead = false; //sets this bool to false 
    }

    void OnTriggerEnter2D(Collider2D collision) //triggers when a colider with the trigger checks is entered 
    {
        if (collision.tag == "Player") //only checks to see fi the player entered it 
        {
            nextPos = EndPosition.position; //moves the block to the end position 
           //Debug.Log("hey"); prints stuff 
        }
    }
    void FixedUpdate() // calls the thing that moves the block 
    {
        if(isded.isdead == true)
        {
            nextPos = StartPosition.position;
        }
    }

    private void Update() //the actual thing that moves the block 
    {
        transform.position = Vector3.MoveTowards(transform.position, nextPos, Speed * Time.deltaTime);
    }
    private void OnDrawGizmos() //makes a line in the scene part of unity 
    {
        Gizmos.DrawLine(StartPosition.position, EndPosition.position);
    }
}

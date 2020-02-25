using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTerrain : MonoBehaviour
{
    public float blockSpeed = 1f;
    
    public float Track = 0f;
       
    // Update is called once per frame
    void Update()
    {  
       
            
            transform.Translate(Vector3.up * Time.deltaTime, Space.Self);
            
            Debug.Log("hi");

        if (Track == 10)
        {
            // transform.Translate(-Vector3.up * Time.deltaTime, Space.Self);
        }
        
    }
}

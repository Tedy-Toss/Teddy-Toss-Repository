using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    int maxY = 8;
    int minY = -8;
    int speed = 2;
    int direction = 1;
    void Start()
    {
        StartCoroutine("moveBlock");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator moveBlock()
    {
        
        while (true)
        {
            if(transform.position.y >= maxY)
            {
                direction = -1;
                Debug.Log("in if " + transform.position.y);
                
            }
            else if(transform.position.y <= minY)
            {
                direction = 1;
                Debug.Log("in else " + transform.position.y);
            }
            
            transform.Translate(0, (speed * Time.deltaTime) * direction, 0);
         
            yield return null;
        }
    }
        
 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTerrain : MonoBehaviour
{
    public int seconds = 3;
       
    
    bool isStarted = true;
    
    Vector3 destination;
    Vector3 origin;
    public Vector3 desiredLocation = new Vector3 (-4.5f, 3.5f, 0f);
    void Update()
    {
        if(isStarted == true)
        {
            StartCoroutine(RisingBlock());
            isStarted = false;
        }
        else
        {

        }

        
       
    }

    public IEnumerator RisingBlock()
    {
       
            float totalMovementTime = 5f;
            float currentMovementTime = 0f;
        origin = transform.position;
        destination = desiredLocation;

        while (Vector3.Distance(transform.localPosition, destination) > 0)
        {
            currentMovementTime += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(origin, destination, currentMovementTime / totalMovementTime);

        }










        /* 
      destination = Vector3.up;
      //oldDestination = destination;

      Debug.Log(destination);
      Debug.Log(this.transform.position + "current pos");

      transform.Translate(Vector3.up * Speed, Space.Self);





      //transform.Translate(Vector3.down * Time.deltaTime, Space.Self);

      yield return new WaitForSeconds(seconds);       
          */




    }
}

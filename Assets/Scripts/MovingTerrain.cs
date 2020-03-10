using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTerrain : MonoBehaviour
{
   public int seconds = 3;
       
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(movingBlock());
        
    }

    private IEnumerator movingBlock()
    {
        transform.Translate(Vector3.up * Time.deltaTime, Space.Self);

        yield return new WaitForSeconds(seconds);

        

        transform.Translate(Vector3.down * Time.deltaTime, Space.Self);
    }
}

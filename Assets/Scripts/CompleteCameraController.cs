using UnityEngine;
using System.Collections;

public class CompleteCameraController : MonoBehaviour {

    public Transform Follow; //Public variable to store a reference to the player game object

    public float smoothSpeed = 10f;

	public Vector3 offset;			//Private variable to store the offset distance between the player and camera
	
	// LateUpdate is called after Update each frame
	void LateUpdate () 
	{
        Vector3 desiredLocation = Follow.position + offset;

        Vector3 smoothedLocation = Vector3.Lerp(transform.position, desiredLocation, smoothSpeed * Time.deltaTime);

        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = smoothedLocation;
      
    }
}

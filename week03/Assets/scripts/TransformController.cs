using UnityEngine;
using System.Collections;

// VERY SIMPLE Transform-based character controller
// has no gravity nor collisions

public class TransformController : MonoBehaviour {

	float moveSpeed = 5f;
	float turnSpeed = 45f;
	
	// Update is called once per frame
	void Update () {
		// move forward
		if ( Input.GetKey (KeyCode.UpArrow) ) {
			transform.position += transform.forward * Time.deltaTime * moveSpeed;
		}
		
		// turn left
		if ( Input.GetKey (KeyCode.LeftArrow) ) {
			transform.Rotate (0f, -turnSpeed * Time.deltaTime, 0f );
		}
		
		// turn right
		if ( Input.GetKey (KeyCode.RightArrow) ) {
			transform.Rotate (0f, turnSpeed * Time.deltaTime, 0f );
		}
	}
}

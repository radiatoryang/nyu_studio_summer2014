using UnityEngine;
using System.Collections;

// uses Unity's built-in "Character Controller" component

public class CharacterControl : MonoBehaviour {

	float moveSpeed = 500f;
	float turnSpeed = 45f;
	float jumpForce = 40f;
	
	// Update is called once per frame
	void Update () {
		// move forward
		if ( Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<CharacterController>().SimpleMove ( transform.forward * moveSpeed * Time.deltaTime );
		}
		
		// turning
		transform.Rotate ( 0f, Input.GetAxis ("Horizontal") * turnSpeed * Time.deltaTime, 0f );
		
		// jump, but only if standing on the ground
		if ( Input.GetKeyUp (KeyCode.Space) && GetComponent<CharacterController>().isGrounded) {
			GetComponent<CharacterController>().Move ( Vector3.up * jumpForce );
		}
		
		// gravity hack
		GetComponent<CharacterController>().Move ( Physics.gravity * 0.1f );
	}
}

using UnityEngine;
using System.Collections;

// Rigidbody-based controller, place it on a Capsule with a Rigidbody (and rotation constraints so it doesn't fall over)
public class RigidbodyControllerBlank : MonoBehaviour {
	// variables are, by default, PRIVATE
	float moveSpeed = 2000f;
	float turnSpeed = 45f;
	float jumpForce = 2000f;
	
	Vector3 moveVector;

	void Update () {
		// turn using horizontal Mouse movement... does NOT use physics system (torque)
		transform.Rotate ( 0f, Input.GetAxis ( "Mouse X" ) * turnSpeed * Time.deltaTime, 0f );
		
		moveVector = transform.forward * Input.GetAxis ("Vertical") + transform.right * Input.GetAxis ("Horizontal");
		moveVector = Vector3.Normalize ( moveVector );
	}
	// ============= OKAY NOW TEST THE CODE ABOVE BEFORE CODING MORE =====================
	// all Physics rigidbody calls should be made in FixedUpdate
	void FixedUpdate () {

		// physics force, movement forward and backward, using keyboard "Vertical" axis
		GetComponent<Rigidbody>().AddForce (  moveVector * moveSpeed * Time.deltaTime );

  // ================ OKAY NOW TEST THE CODE ABOVE BEFORE CODING MORE ==========================
		// jump up, if spacebar is pressed
		if ( Input.GetKeyUp ( KeyCode.Space ) ) {
			GetComponent<Rigidbody>().AddForce ( Vector3.up * jumpForce );
		}
	}   // DID YOU FINISH EARLY? Then figure out how to use Raycasts to do a "grounded" check for the jump

}

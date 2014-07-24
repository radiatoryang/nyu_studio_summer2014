using UnityEngine;
using System.Collections;

// Rigidbody-based controller, place it on a Capsule with a Rigidbody (and rotation constraints so it doesn't fall over)
public class RigidbodyController : MonoBehaviour {
	#region variables
	float moveSpeed = 2000f;
	float turnSpeed = 45f;
	float jumpForce = 2000f;
	#endregion
	// Update is called once per frame
	void Update () {
		// turn using horizontal Mouse movement... does NOT use physics system (torque)
		???.Rotate ( 0f, Input.GetAxis ( "Mouse X" ) * turnSpeed * Time.???, 0f );
	}
	
	// all Physics rigidbody calls should be made in FixedUpdate
	void FixedUpdate () {
		// physics force, movement forward and backward, using keyboard "Vertical" axis
		GetComponent<???>().AddForce ( transform.??? * Input.GetAxis (???) * moveSpeed * Time.??? );
		// physics force, movement sideways, using keyboard Horizontal axis
		GetComponent<???>().??? ( transform.right * Input.GetAxis (???) * moveSpeed * Time.??? );
		
		// jump up, if spacebar is pressed
		if ( Input.GetKeyUp (???) ) {
			GetComponent<???>().AddForce ( Vector3.??? * jumpForce );
		}
	}
}

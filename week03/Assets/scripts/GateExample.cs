using UnityEngine;
using System.Collections;

// PUT THIS SCRIPT ON A "KEY" object with a trigger-collider
public class GateExample : MonoBehaviour {

	public Transform door; // WHICH DOOR? ASSIGN IN UNITY INSPECTOR
	
	// You will need a trigger-collider on this object
	void OnTriggerEnter ( ) {		
		// destroy door because we picked up the key
		Destroy ( door.gameObject );
		
		// destroy key because we picked it up
		Destroy ( gameObject );
	}
}

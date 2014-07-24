using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	bool isKimHere = false;
	public Transform ladder;

	void OnTriggerEnter ( Collider bradPitt ) {
		//Destroy ( bradPitt.gameObject );
		isKimHere = true;
		
	}
	
	void Update () {
		if (isKimHere == true && Input.GetKeyDown (KeyCode.Space)) {
			// open Kim's car odor
			ladder.position = Vector3.zero;
		}
	}
}

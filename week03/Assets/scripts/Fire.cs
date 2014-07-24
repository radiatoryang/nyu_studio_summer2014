using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	void OnTriggerEnter ( Collider bradPitt ) {
		Destroy ( bradPitt.gameObject );
	}

}

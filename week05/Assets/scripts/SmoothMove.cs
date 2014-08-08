using UnityEngine;
using System.Collections;

public class SmoothMove : MonoBehaviour {

	public Vector3 destination; // edit in inspector
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp ( transform.position, destination, Time.deltaTime * 10f );
	}
}

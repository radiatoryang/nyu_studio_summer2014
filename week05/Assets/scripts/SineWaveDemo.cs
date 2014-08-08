using UnityEngine;
using System.Collections;

public class SineWaveDemo : MonoBehaviour {

	Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// Time.time is the NUMBER IN SECONDS since the game started (it's a timer)
		// to speed up: multiply by a number > 1 INSIDE sine function
		// to increase bounce height: multiply by number > 1 OUTSIDE sine function
		transform.position = startPosition +
							 new Vector3(0f, 1f, 0f) * Mathf.Sin( Time.time * 5f ) * 2f;
		transform.localScale = new Vector3(1f, 1f, 1f) * Mathf.Sin ( Time.time * 10f );
		transform.localEulerAngles = new Vector3(0f, Mathf.Sin (Time.time) * 30f, 0f );
	}
}

using UnityEngine;
using System.Collections;

public class RaycastDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// construct a ray (an origin and a direction)
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		// initialize a "RaycastHit" info container
		RaycastHit rayHit = new RaycastHit(); // empty, blank
		
		// actually shoot the raycast now
		if ( Physics.Raycast ( ray, out rayHit, 1000f ) 
		&& Input.GetMouseButtonDown (0) ) {
			Destroy ( rayHit.transform.gameObject );
		}
	}
}

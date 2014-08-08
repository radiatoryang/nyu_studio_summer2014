using UnityEngine;
using System.Collections;

public class FlyControl : MonoBehaviour {

	public float speedMove = 5f;
	public float speedTurn = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// restart game by reloading scene #0, as set in list in File >> Build Settings
		if (Input.GetKeyDown (KeyCode.R))
			{	Application.LoadLevel (0); }
			
		transform.Rotate (Input.GetAxis ("Mouse Y"), Input.GetAxis ("Mouse X") * speedMove, 0f);
		transform.eulerAngles = new Vector3( transform.eulerAngles.x, transform.eulerAngles.y, 0f );
	}
	
	void FixedUpdate () {
		if (Input.GetMouseButton(0)) {
			Screen.lockCursor = true;
			rigidbody.AddForce ( -transform.forward * speedMove );
		}
	}
}

using UnityEngine;
using System.Collections;

public class BallSwap : MonoBehaviour {

	public Transform ball1, ball2; // assign in the Inspector
	public float delay = 1f;

	// Use this for initialization
	void Start () {
		StartCoroutine ( BallCoroutine() );
	}
	
	// a coroutine: a special function that can pause / last more than 1 frame
	IEnumerator BallCoroutine () {
		Debug.Log ( "the coroutine started!");
		yield return 0; // wait one frame
		yield return 0; // wait another frae
		Debug.Log ( "two frames elapsed" );
		yield return new WaitForSeconds( 2.3f );
		Debug.Log ( "now 2.3 seconds have elapsed!" );
		yield return new WaitForSeconds( Random.Range (0f, 5f) );
		yield return new WaitForSeconds( delay );
		
		// lerping with while() loops
		while ( true ) {
			Vector3 ball1Pos = ball1.position; // remember initial ball positions
			Vector3 ball2Pos = ball2.position;
			float t = 0f;
			bool didIPlayASoundAlready = false;
			while ( t < 1f ) { // lerp as long as t is less than 1
				t += Time.deltaTime;
				if ( t >= 0.5f && !didIPlayASoundAlready ) {
					audio.Play ();
					StartCoroutine ( ScreenShake(0.5f) );
					didIPlayASoundAlready = true;
				}
				ball1.position = Vector3.Lerp ( ball1Pos, ball2Pos, t);
				ball2.position = Vector3.Lerp ( ball2Pos, ball1Pos, t);
				yield return 0;
			}
			yield return 0;
		}
		
	}
	
	IEnumerator ScreenShake ( float duration, float shakeSpeed = 20f ) {
		float t = 1f; // value from 0 to 1
		Vector3 cameraStartPos = Camera.main.transform.position;
		while ( t > 0f ) {
			t -= Time.deltaTime / duration;
			Camera.main.transform.position = cameraStartPos +
											 Camera.main.transform.right * Mathf.Sin(Time.time * shakeSpeed) * t +
											 Camera.main.transform.up * Mathf.Sin(Time.time * shakeSpeed * 1.1f) * t;
			yield return 0;
		}
	
	}
	
	
	
	
	
	
	// Update is called once per frame
	void Update () {
	
	}
}

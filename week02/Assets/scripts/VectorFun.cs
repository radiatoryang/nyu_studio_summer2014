using UnityEngine;
using System.Collections;

public class VectorFun : MonoBehaviour {

	public float speed = 5f;
	public Vector3 direction;

	// Use this for initialization
	void Start () {
		Debug.Log ( GetComponent<Transform>().position );
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Transform>().position += direction * Time.deltaTime * speed;
	}
}

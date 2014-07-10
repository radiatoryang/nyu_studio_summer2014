using UnityEngine;
using System.Collections;

public class PoemManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		Debug.Log("Hello World");
		
		GetComponent<TextMesh>().text = "Bonjour Monde\nBienvenidos\nBlah";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

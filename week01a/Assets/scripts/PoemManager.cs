using UnityEngine;
using System.Collections;

public class PoemManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// spits out "Hello World" to Unity's console tab
		Debug.Log("Hello World");
		// changes the text on the text mesh to say ____.
		GetComponent<TextMesh>().text = "Bonjour Monde\nBienvenidos\nBlah";
		// remember, type "\n" to denote a line break, like above!
	}

}

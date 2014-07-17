using UnityEngine;
using System.Collections;

public class TenPrint : MonoBehaviour {

	int characterCounter = 0;
	
	// Update is called once per frame
	void Update () {
		int coin = Random.Range (0, 2); // will give 0 or 1
		
		// is the coin heads or tails?
		if ( coin == 1 ) 
		{
			GetComponent<TextMesh>().text = GetComponent<TextMesh>().text + "/";
		} 
		else 
		{
			GetComponent<TextMesh>().text += "\\";
		}
		
		//characterCounter = characterCounter + 1;
		characterCounter++; // exactly the same as the line of code above
		
		if ( characterCounter > 20 ) {
			GetComponent<TextMesh>().text += "\n";
			characterCounter = 0;
		}
	}
}








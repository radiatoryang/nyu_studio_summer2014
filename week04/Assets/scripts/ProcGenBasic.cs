using UnityEngine;
using System.Collections;

public class ProcGenBasic : MonoBehaviour {

	public float spawnRadius = 100f;
	public int spawnCount = 100;

	// OLD IMPLEMENTATION that doesn't use arrays
	//public Transform small, medium, big, tall; // assign in reference in Inspector
	
	public Transform[] prefabs; // an "array" is a list of things in 1 variable

	// Use this for initialization
	void Start () {
		int counter = 0; // I can name this variable whatever I want, but "counter" makes the most sense to me
		while ( counter < spawnCount ) { // as long as this expression is true, it will keep looping
		
			Transform prefabToSpawn; // starts blank
			int prefabIndex = Random.Range (0, 4); // possible numbers: 0, 1, 2, 3 (NOT 4)
			
			// OLD IMPLEMENTATION that doesn't use arrays
//			if (prefabIndex == 0) {
//				prefabToSpawn = small;
//			} else if ( prefabIndex == 1) {
//				prefabToSpawn = medium;
//			} else if ( prefabIndex == 2) {
//				prefabToSpawn = big;
//			} else {
//				prefabToSpawn = tall;
//			}

			prefabToSpawn = prefabs[prefabIndex];
		
			// Instantiate = spawn new copies during the game!
			// I could put this all on one line if I wanted to, but I am doing this to show you the structure:
			Instantiate ( 	prefabToSpawn, 
					 	  	new Vector3( 
					 	  			Random.Range (-spawnRadius, spawnRadius), 
					 	  			0f, 
					 	  			Random.Range(-spawnRadius, spawnRadius) 
					 	  	),
					  	  	Quaternion.identity 
						);
			counter++; // add 1 to "counter" after each loop
		}	
		
	}
	
	
	// Update is called once per frame
	void Update () {
	
	}
}

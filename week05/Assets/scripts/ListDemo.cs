using UnityEngine;
using System.Collections;

// YOU NEED THIS LINE HERE TO USE LISTS
using System.Collections.Generic; // YOU NEED THIS LINE HERE TO USE LISTS
// YOU NEED THIS LINE HERE TO USE LISTS

public class ListDemo : MonoBehaviour {

	public Transform prefab;
	public List<Transform> allMyClones = new List<Transform>(); // initialize the list

	// Use this for initialization
	void Start () {
		
		// as long as this list has less than 100 clones, keep cloning
		while ( allMyClones.Count < 100 ) {
			// to remember the clone, we must CAST it ("... as Transform") at the end of the line
			Transform newClone = Instantiate (prefab, Random.insideUnitSphere * 10f, Random.rotation) as Transform;
			allMyClones.Add (newClone); // actually add this to the list now
		}
		
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) ) {
			// "for" or "foreach" is used for ITERATING through a list, like doing X to everything in Y list
			foreach ( Transform clone in allMyClones ) {
				clone.LookAt (Vector3.zero);
			}
			
			// if you want to delete things, you CANNOT use foreach()
			// remove a clone if it is too close to 0,0,0
			for ( int i=0; i<allMyClones.Count; i++ ) {
				if ( allMyClones[i].position.magnitude < 5f ) {
					Destroy ( allMyClones[i].gameObject );
					allMyClones.Remove ( allMyClones[i] ); // remove from list
					// allMyClones.RemoveAt( i ); // the same thing as above
					
					// if ( allMyClones.Contains( transform ) )
				}
			}
			
		}
	}
	
}

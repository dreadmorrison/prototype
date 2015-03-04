using UnityEngine;
using System.Collections;

public class trap : MonoBehaviour {

	Collider currentlyInside;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if there is something currently inside this trigger
		if (currentlyInside != null) {
			//then damage it
			currentlyInside.GetComponent<Hurtable>().health -= Time.deltaTime * 5f;
		}
	}
	//Unity automatically calls this function when an object w/
	//Rigidbody enters this object's trigger-collider AND tell you
	//what entered it
	void OnTriggerEnter ( Collider activator ) {
		currentlyInside = activator;//remembers thing that entered trigger
	}

	void OnTriggerExit (Collider exited ) {
		//"null" means nothing, empty, absence, absolute nothingness
		currentlyInside = null;
	}
}

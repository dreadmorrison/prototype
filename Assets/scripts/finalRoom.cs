using UnityEngine;
using System.Collections;

public class finalRoom : MonoBehaviour {
	
	Collider inside; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (inside != null) {
			//then damage it
			particleSystem.Play ();
			inside.GetComponent<Hurtable>().health += Time.deltaTime * 20f;
		}
	}
	void OnTriggerEnter ( Collider activator ) {
		inside = activator;//remembers thing that entered trigger
	}
	
	void OnTriggerExit (Collider exited ) {
		//"null" means nothing, empty, absence, absolute nothingness
		inside = null;
	}
}

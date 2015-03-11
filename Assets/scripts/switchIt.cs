using UnityEngine;
using System.Collections;

public class switchIt : MonoBehaviour {

	public GameObject door;
	Collider inside; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (inside != null) {
			//then damage it
			Destroy (door);
			Destroy (this.gameObject);
		}
	}
	void OnTriggerEnter ( Collider activator ) {
		inside = activator;//remembers thing that entered trigger
		inside.GetComponent<Cheese>().cheese += 1;
	}
	
	void OnTriggerExit (Collider exited ) {
		//"null" means nothing, empty, absence, absolute nothingness
		inside = null;
	}
}

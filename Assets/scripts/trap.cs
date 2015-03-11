using UnityEngine;
using System.Collections;

public class trap : MonoBehaviour {

	Collider thingCurrentlyInside;
	public float damage = 5f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (thingCurrentlyInside != null){
			thingCurrentlyInside.GetComponent<Hurtable>().health -= Time.deltaTime * damage;
		}
	}
	
	
	// Unity automatically calls this function when an object with 
	// a rigidbody enters this objects trigger collider, AND it will tell you WHAT entered it.
	
	void OnTriggerEnter (Collider activator) {
		thingCurrentlyInside = activator; // catch it in a variable.
	}
	
	void OnTriggerExit ( Collider exiter){
		thingCurrentlyInside = null;
	} 
}

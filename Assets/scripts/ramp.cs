using UnityEngine;
using System.Collections;

public class ramp : MonoBehaviour {

	public float speed;

	public Rigidbody buddy;

	
	// Use this for initialization
	void Start () {
		
	}
	
	
	// Unity automatically calls this function when an object with 
	// a rigidbody enters this objects trigger collider, AND it will tell you WHAT entered it.
	
	void OnTriggerEnter (Collider activator) {
		buddy.AddForce(transform.right * speed);
		 // catch it in a variable.
	}
	
	void OnTriggerExit ( Collider exiter){

	} 
}

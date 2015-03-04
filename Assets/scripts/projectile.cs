using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {

	public Rigidbody rocket;
	public float speed = 10f;
	
	void FireRocket () {
		Rigidbody rocketClone = (Rigidbody) Instantiate(rocket, transform.position, transform.rotation);
		rocketClone.velocity = transform.forward * speed;

	}
	
	// Calls the fire method when holding down ctrl or mouse
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			FireRocket();
		}
	}
}

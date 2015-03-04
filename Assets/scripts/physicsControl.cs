﻿using UnityEngine;
using System.Collections;

public class physicsControl : MonoBehaviour {

	public float speed = 5f;
	public float turnSpeed = 45f;
	Rigidbody rbuddy;

	// Use this for initialization
	void Start () {
		//"caching" a reference to the rigidbody
		rbuddy = GetComponent<Rigidbody>();
	
	}
	
	// FixedUpdate is called on a fixed interval for every physics frame
	void FixedUpdate () {
	
		//INPUT AXES: a virtual joystickk that returns a float from -1 to 1

		rbuddy.AddForce ( transform.forward * speed * Input.GetAxis ("Vertical") );
		rbuddy.AddForce ( transform.right * speed * Input.GetAxis ("Horizontal") );

		//turning
		//transform.Rotate ( 0f, Input.GetAxis ("Horizontal") * turnSpeed, 0f );
	}
}

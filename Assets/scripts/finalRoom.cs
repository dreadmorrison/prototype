using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class finalRoom : MonoBehaviour {
	
	public Text text;
	// Use this for initialization
	void Start () {
		
	}


	void OnTriggerEnter ( Collider activator ) {
		text.text = "You ate all\nthe cheese!\nYUM";

	}
	
	void OnTriggerExit (Collider exited ) {
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cheese : MonoBehaviour {

	public Text text;
	public int cheese = 0;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Cheese: " + cheese; 
	}
}

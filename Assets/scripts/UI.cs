using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

		float health = GetComponent<Hurtable>().health;

		string textBuffer = "Health: " + health.ToString();

		GetComponent<Text>().text = textBuffer;

	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hurtable : MonoBehaviour {

	public Text text;
	public float health = 100f;
	public GameObject player;

	void Start() {

	}

	// Update is called once per frame
	void Update () {

		health = Mathf.Round(health * 100f) / 100f;
		text.text = "Health: " + health; 

	if ( health <= 0f ) {

			player.transform.position = new Vector3(40, 2, 33);
			health = 100f;
		
		}
	}
}

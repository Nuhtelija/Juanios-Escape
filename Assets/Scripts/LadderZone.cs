using UnityEngine;
using System.Collections;

public class LadderZone : MonoBehaviour {

	private PlayerScript thePlayer;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerScript> ();
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "Player") {
			thePlayer.onLadder = true;
		}
	}

	void OnTriggerExit2D(Collider2D other){

		if (other.name == "Player") {
				thePlayer.onLadder = false;
		}
	}

}

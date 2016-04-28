using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour {

	private PlayerScript thePlayer;


	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<PlayerScript> ();
	}
	

	public void LeftArrow() {

		thePlayer.Move (-1);
	
	}

	public void RightArrow() {

		thePlayer.Move (1);

	}

	public void UnPressedArrow() {

		thePlayer.Move (0);

	}

	public void Shoot() {

		thePlayer.Fire ();

	}

	public void Jump() {

		thePlayer.Jump ();

	}
}

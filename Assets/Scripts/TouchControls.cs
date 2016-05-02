using UnityEngine;
using System.Collections;

/// <summary>
/// This script gives functions to buttons so the game can be played on phone.
/// </summary>
public class TouchControls : MonoBehaviour {

	private PlayerScript thePlayer;

	private LevelLoader levelExit;

	private PauseMenu thePauseMenu;


	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<PlayerScript> ();

		levelExit = FindObjectOfType<LevelLoader> ();

		thePauseMenu = FindObjectOfType<PauseMenu> ();
	}


    /// <summary>
    /// Moves player to left.
    /// </summary>
    public void LeftArrow() {

		thePlayer.Move (-1);
	
	}

    /// <summary>
    /// Moves player to right.
    /// </summary>
    public void RightArrow() {

		thePlayer.Move (1);

	}

    /// <summary>
    /// Player stays still when nothing is pressed.
    /// </summary>
    public void UnPressedArrow() {

		thePlayer.Move (0);

	}

    /// <summary>
    /// Makes player shoot
    /// </summary>
    public void Shoot() {

		thePlayer.Fire ();

	}

    /// <summary>
    /// Makes player jump.
    /// </summary>
    public void Jump() {

		thePlayer.Jump ();

		if (levelExit.playerInZone) {
			levelExit.LoadLevel ();
		}

	}

    /// <summary>
    /// Pauses and unpauses the game.
    /// </summary>
    public void Pause() {
		thePauseMenu.PauseUnpause ();
		
	}
}

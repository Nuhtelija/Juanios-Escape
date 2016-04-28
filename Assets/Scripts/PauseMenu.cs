﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public string levelSelect;

	public string mainMenu;

	public bool isPaused;

	public GameObject pauseMenuCanvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (isPaused) {
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0f;
		} else {
			pauseMenuCanvas.SetActive (false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			PauseUnpause ();
		}
	
	}

	public void PauseUnpause() {
		isPaused = !isPaused;
	}

	public void Resume(){
		isPaused = false;
	}

	public void QuitGame(){

		SceneManager.LoadScene (mainMenu);
	}
}

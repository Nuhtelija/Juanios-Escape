﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Kills player when called.
/// </summary>
public class KillPlayer : MonoBehaviour {

	public LevelManager levelManager;

	// Use this for initialization
	void Start () {

		levelManager = FindObjectOfType<LevelManager> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "Player") {
			other.GetComponent<AudioSource>().Play ();
			levelManager.RespawnPlayer ();
		}
	}
}

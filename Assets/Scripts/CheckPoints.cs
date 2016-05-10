using UnityEngine;
using System.Collections;

/// <summary>
/// This class creates checkpoint.
/// </summary>
public class CheckPoints : MonoBehaviour {

	public LevelManager levelManager;


	void Start () {

			levelManager = FindObjectOfType<LevelManager> ();

		}

   
    /// <summary>
    /// Gives current checkpoint to levelManager
    /// </summary>
    void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "Player") {
			levelManager.currentCheckpoint = gameObject;
	}
}

}

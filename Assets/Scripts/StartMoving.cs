using UnityEngine;
using System.Collections;


/// <summary>
/// Moves platform when player collides with it
/// </summary>
public class StartMoving : MonoBehaviour {


    GameObject platform;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            gameObject.GetComponentInChildren<MovingPlatform>().enabled = true;
        }
    }
}

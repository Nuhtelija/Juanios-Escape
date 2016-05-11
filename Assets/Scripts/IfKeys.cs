using UnityEngine;
using System.Collections;


/// <summary>
/// Checks if player has all the keys
/// </summary>
public class IfKeys : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player" && PickUp.keys == 3)
        {
            gameObject.GetComponentInChildren<MovingPlatform>().enabled = true;
        }
    }
}

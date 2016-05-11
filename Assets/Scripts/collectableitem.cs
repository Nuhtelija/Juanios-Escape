using UnityEngine;
using System.Collections;


/// <summary>
/// Destroys unwanted item
/// </summary>
public class collectableitem : MonoBehaviour {

    /// <summary>
    /// If object collides with player tagged object it will be destroyed
    /// </summary>
    /// <param name="other">The other.</param>
    void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			Destroy (gameObject);
		}
	}
}

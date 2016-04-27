using UnityEngine;
using System.Collections;

public class NinjaStarController : MonoBehaviour {

	public float speed;

	public PlayerScript player;

	public GameObject enemyDeathEffect;

	public GameObject impactEffect;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerScript> ();

		if(player.transform.localScale.x < 0)
			speed = -speed;
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D>().velocity = new Vector2 (speed, GetComponent<Rigidbody2D>().velocity.y);
	
	}

	void OnTriggerEnter2D(Collider2D other){

		Instantiate (impactEffect, transform.position, transform.rotation);
		Destroy (gameObject);

		if (other.tag == "Enemy") {
			Instantiate (enemyDeathEffect, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
		}
	}
}

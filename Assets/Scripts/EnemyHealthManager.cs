﻿using UnityEngine;
using System.Collections;

/// <summary>
/// This script gives enemy health. If health drops to 0, then enemy will be destroyed.
/// </summary>
public class EnemyHealthManager : BossAI
{

    public int enemyHealth;

<<<<<<< HEAD
	public GameObject deathEffect;
    public GameObject levelexit;
=======
    public GameObject deathEffect;

>>>>>>> master

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    /// <summary>
    /// Used deatheffect when enemy health drops to 0 and destroys enemy
    /// </summary>
<<<<<<< HEAD
    void Update () {
        if (enemyHealth <= 0 && gameObject.name == "Boss1") {
            Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            Instantiate(levelexit, transform.position, transform.rotation);
        }
		if (enemyHealth <= 0) {
			Instantiate (deathEffect, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	
	}
=======
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }
>>>>>>> master

    /// <summary>
    /// Gives damage to enemy and play sound on hit.
    /// </summary>
    /// <param name="damageToGive">The damage to give.</param>
    public void giveDamage(int damageToGive)
    {
        enemyHealth -= damageToGive;
        GetComponent<AudioSource>().Play();
    }
}

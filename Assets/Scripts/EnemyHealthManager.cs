using UnityEngine;
using System.Collections;

/// <summary>
/// This script gives enemy health. If health drops to 0, then enemy will be destroyed.
/// </summary>
public class EnemyHealthManager : BossAI
{

    public int enemyHealth;

    public GameObject deathEffect;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    /// <summary>
    /// Used deatheffect when enemy health drops to 0 and destroys enemy
    /// </summary>
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }

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

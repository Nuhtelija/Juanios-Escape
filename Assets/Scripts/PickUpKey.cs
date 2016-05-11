﻿using UnityEngine;
using System.Collections;


/// <summary>
/// Sets gameobject inactive when player collides it
/// </summary>
public class PickUpKey : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    Rigidbody2D myRigidBody2D; //Rigidbody of the Projectiles
    public float speed;
    Hero hero;
    
    // Use this for initialization
    void Start ()
    {
        Shooting();
	}

    /// <summary>
    /// Making the Projectiles Move
    /// </summary>
    public void Shooting()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        // myRigidBody2D.velocity = transform.right * speed;
        hero = FindObjectOfType<Hero>();
        myRigidBody2D.velocity = hero.angle * speed;
    }

    /// <summary>
    /// Destroying the projectiles on trigger
    /// </summary>
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        Destroy(gameObject);
    }


}


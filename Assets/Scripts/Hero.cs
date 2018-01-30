using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    
    Rigidbody2D myRigidBody2D;
    public float playerSpeed = 4f;
    
    public Needles needle;
    public float bulletspeed;
    public Transform shootpos;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
     Shoot();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Needles newNeedle = Instantiate(needle, shootpos.position, shootpos.rotation);
            newNeedle.speed = bulletspeed;
        } 
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    Rigidbody2D myRigidBody2D;

	// Use this for initialization
	void Start () {
        myRigidBody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
    }

    private void FixedUpdate()
    {
        
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newPosition = transform.position;
            transform.position += new Vector3(0.02f, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 newPosition = transform.position;
            transform.position += new Vector3(0, 0.02f, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 newPosition = transform.position;
            transform.position += new Vector3(-0.02f, 0, 0);
        }

         if (Input.GetKey(KeyCode.S))
        {
            Vector3 newPosition = transform.position;
            transform.position += new Vector3(0, -0.02f, 0);
        }
    }
}

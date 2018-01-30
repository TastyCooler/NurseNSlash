using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needles : MonoBehaviour {

    public float speed = 0.1f;
    Hero player;

    // Use this for initialization
    void Start () {
        player = FindObjectOfType<Hero>();
    }
	
	// Update is called once per frame
	void Update () {
        NeedleMovement();

    }

    void NeedleMovement()
    {
        transform.Translate(Vector3.right * speed);
    }
}

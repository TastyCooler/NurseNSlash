using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : MonoBehaviour {

    int hp = 3;
    public GameObject projectile;

	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D trigger)
    {

        hp--;
        

        if (hp <= 0)
        {
            
            Destroy(gameObject);
        }
        
    }
}

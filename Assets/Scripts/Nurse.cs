using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : MonoBehaviour {

    int hp = 3;
    public GameObject projectile;
    Hero hero;

	// Use this for initialization
	void Start () {
        hero = FindObjectOfType<Hero>();

    }
	
	// Update is called once per frame
	void Update () {
        Debug.LogFormat("Nurses hp:{0}", hp);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Bullets : MonoBehaviour {

    Hero hero;

	// Use this for initialization
	void Start ()
    {
        hero = FindObjectOfType<Hero>();
	}
	
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hero.bulletpowerup = true; 
        Destroy(gameObject);
        //Debug.LogFormat("hp is: {0}", hero.hp);
    }
}

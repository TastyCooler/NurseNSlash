using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Health : MonoBehaviour {

    Hero hero;

	// Use this for initialization
	void Start () {
        hero = FindObjectOfType<Hero>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hero.hp += 3;
        Destroy(gameObject);
        //Debug.LogFormat("hp is: {0}", hero.hp);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : MonoBehaviour {

    int hp = 4;
    Hero hero;
    Score score;

	// Use this for initialization
	void Start () {
        hero = FindObjectOfType<Hero>();
        score = FindObjectOfType<Score>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.LogFormat("Nurses hp:{0}", hp);
    }

    
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        takedamage();
        
        if (hp <= 0)
        {
            score.KillScore(); //Getting Points for Killing 
            Destroy(gameObject); // Deleting the GameObject(Nurse)
        }
    }

    void takedamage()
    {
        hp -= hero.damage; //Calculator, can be used for other new features later on
    }
}

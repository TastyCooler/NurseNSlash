using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : MonoBehaviour {

    int hp = 3;
    public GameObject projectile;
    Hero hero;
    Score score;

	// Use this for initialization
	void Start () {
        hero = FindObjectOfType<Hero>();
        score = FindObjectOfType<Score>();
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
            
            score.KillScore();
           
            Destroy(gameObject);
            
        }
        
    }
}

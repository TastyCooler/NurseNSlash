using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : MonoBehaviour {

    int hp = 4;
    Hero hero;
 
    public int scoreValue = 150;
    private ScoreKeeper scoreKeeper;

    // Use this for initialization
    void Start () {
        hero = FindObjectOfType<Hero>();
        scoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
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
            
            Destroy(gameObject); // Deleting the GameObject(Nurse)
            scoreKeeper.Score(scoreValue);   //Getting Points for Killing 
        }
    }

    void takedamage()
    {
        hp -= hero.damage; //Calculator, can be used for other new features later on
    }
}

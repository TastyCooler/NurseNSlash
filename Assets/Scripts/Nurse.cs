using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : MonoBehaviour {
<<<<<<< HEAD
    
    

	// Use this for initialization
	void Start () {
        
=======

    int hp = 4;
    Hero hero;

	// Use this for initialization
	void Start () {
        hero = FindObjectOfType<Hero>();
>>>>>>> efcda3c8ab8fe4c8e0c49cfeed733d717c313ba5

    }
	
	// Update is called once per frame
<<<<<<< HEAD
	void Update ()
    {
        //Debug.LogFormat("Nurses hp:{0}", hp);
    }
=======
	void Update () {
<<<<<<< HEAD
		
=======
>>>>>>> efcda3c8ab8fe4c8e0c49cfeed733d717c313ba5
	}
>>>>>>> c8a6bc3d15aff8941f711d89d91fe0dc50bdd3bd

    
    private void OnTriggerEnter2D(Collider2D trigger)
    {
<<<<<<< HEAD
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
=======
       

        
<<<<<<< HEAD
            Destroy(gameObject);
        
       
        
=======

        if (hp <= 0)
        {
            
            Destroy(gameObject);
        }
>>>>>>> efcda3c8ab8fe4c8e0c49cfeed733d717c313ba5
        
>>>>>>> c8a6bc3d15aff8941f711d89d91fe0dc50bdd3bd
    }
}

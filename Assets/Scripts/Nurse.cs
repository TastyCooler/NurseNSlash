using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : MonoBehaviour {
<<<<<<< HEAD
    
    

	// Use this for initialization
	void Start () {
        
=======

    int hp = 3;
    public GameObject projectile;
    Hero hero;

	// Use this for initialization
	void Start () {
        hero = FindObjectOfType<Hero>();
>>>>>>> efcda3c8ab8fe4c8e0c49cfeed733d717c313ba5

    }
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		
=======
>>>>>>> efcda3c8ab8fe4c8e0c49cfeed733d717c313ba5
	}

    private void OnTriggerEnter2D(Collider2D trigger)
    {
       

        
<<<<<<< HEAD
            Destroy(gameObject);
        
       
        
=======

        if (hp <= 0)
        {
            
            Destroy(gameObject);
        }
>>>>>>> efcda3c8ab8fe4c8e0c49cfeed733d717c313ba5
        
    }
}

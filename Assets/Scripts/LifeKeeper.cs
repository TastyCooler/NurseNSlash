using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeKeeper : MonoBehaviour {

    Text mytext;
    Hero hero;

	// Use this for initialization
	void Start () {
        mytext = GetComponent<Text>();
        hero = FindObjectOfType<Hero>();
    }
	
	// Update is called once per frame
	void Update () {
        mytext.text = "Lifes:" + hero.hp.ToString();
    }
}

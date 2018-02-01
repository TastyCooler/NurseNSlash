using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    float score;
    

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        Debug.LogFormat("score is: {0}", score);
        
        TimeScore();
    }

    public void KillScore()
    {
        score += Random.Range(10, 21);
        Mathf.Round(score);
    }

    void TimeScore()
    {
        score += Time.deltaTime;
        Mathf.Round(score);
    }

}

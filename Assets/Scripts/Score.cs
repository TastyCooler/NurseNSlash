using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    

    float score; 
    Text myText;

    private void Awake()
    {
        
           //TODO: KEEPING SCORE AFTER DEATH: GameObject.DontDestroyOnLoad(gameObject);
        
    }

    private void Start()
    {
        myText = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update ()
    {
        //Debug.LogFormat("score is: {0}", score);
        TimeScore();
        myText.text = "Score:" + score.ToString();

    }

    /// <summary>
    /// If there's no Hero; After killing an Enemy, add 10 - 20 points to the Score
    /// </summary>
    public void KillScore()
    {
        if (FindObjectOfType<Hero>()!= null)
        {
            score += Random.Range(10, 21);
            
        }
        
    }

    /// <summary>
    /// If there's no Hero; Add Score with the time it took to complete the last frame
    /// </summary>
    void TimeScore()
    {
        if (FindObjectOfType<Hero>() != null)
        {
          score += Time.deltaTime;
          
        }
    }

   
}

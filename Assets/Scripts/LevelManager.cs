using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    Hero hero;
    private void Start()
    {
        hero = FindObjectOfType<Hero>();
    }

    private void Update()
    {
        Death();
    }

    public void LoadLevel(string name)
    {
        //Debug.Log("Level load requested for: " + name);
        SceneManager.LoadScene(name);
    }
    public void QuitRequest()
    {
       // Debug.Log("I want to quit! " + name);
        Application.Quit();
    }

    /// <summary>
    /// Lose Screen
    /// </summary>
    public void Death()
    {
        if (hero != null && hero.hp <= 0)
        {
            SceneManager.LoadScene(3);
        } else
        {
            return;
        }
    }


}

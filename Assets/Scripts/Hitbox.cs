using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    Hero hero;
    private bool triggered = false;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered = true;
        hero = FindObjectOfType<Hero>();
        hero.hp -= 1;
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;
    }

    public bool Triggered()
    {
        return triggered;
    }

}


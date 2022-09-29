using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health; // Keeps track of the players current health
    public int maxHealth = 10; // How much health you have when you are at full health
    [SerializeField] private GameObject Background;
    [SerializeField] private GameObject healthBar;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount) // This function will be called anytime the player takes damage/ amount = how much damage the player takes.
    {
        health -= amount;
        if(health <= 0)
        {                           // If the damage takes the player down to zero or below the the player will be destoyed
            Destroy(gameObject);
            Background.SetActive(true);
            healthBar.SetActive(false);
        }

      

    }

    
}

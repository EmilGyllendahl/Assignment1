using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;  // This lets the EnemyDamage script know where to find the PlayerHealth script in Unity
    public int damage = 2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Bullet");
        GameObject.Find("Player 1");
        GameObject.Find("Player 2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) // This function is called whenever something enters the enemy´s collider.
    {
        if(collision.gameObject.name == "Bullet")
        {
            playerHealth.TakeDamage(damage); // Talks to the PlayerHealth scripts/ and then to the TakeDamage function, health will subtract by 1 each hit.
        }
    }
}

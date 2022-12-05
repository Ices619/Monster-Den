using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health;
    public int maxHealth = 3;

    public SpriteRenderer PlayerSR;
    public Player1 playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        Health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            PlayerSR.enabled = false;
            playerMovement.enabled = false; 
        }
    }
}

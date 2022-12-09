using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //Sets the variables to int
    public int Health;
    public int maxHealth = 3;
    //Calls sprite and Player1 Script
    public SpriteRenderer PlayerSR;
    public Player1 playerMovement;
    // void Start changes or equals to the health variable to Maxhealth
    void Start()
    {
        Health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        //If the health drops to zero, the player will disappear and will load/transport you to the You Died! screeen
        Health -= amount;
        if (Health <= 0)
        {
            PlayerSR.enabled = false;
            playerMovement.enabled = false;
            SceneManager.LoadScene("GameOver");
        }
    }
}

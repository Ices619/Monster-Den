using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    //Sets a bunch of variables i want to use for the sprite of the UI and Health System
    public int Health;
    public int MaxhHealth;

    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;

    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update keeps track of the players health and displays the amount of health the player has left starting at 3
    void Update()
    {
        Health = playerHealth.Health;
        MaxhHealth = playerHealth.maxHealth;
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < MaxhHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}

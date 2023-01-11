using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBehavior : MonoBehaviour
{
    //Creating an instance of this script to be accessable through prefabs
    public static PlayerBehavior Instance;
    
    void Awake()
    {
        Instance = this;
    }

    //This Event helps you to manage to stop actions
    public static event Action playerDeath;


    [SerializeField] private HealtBarScript healthBar;

    public int currentHealth;
    public int maxHealth;
    public bool playerAlive = true;
    public int killCount;

    // Start is called before the first frame update
    void Start()
    {
        killCount = 0;
        currentHealth = maxHealth;
        healthBar.SetCurrentHealth(currentHealth, maxHealth);
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            playerAlive = false;
            Destroy(gameObject);
            playerDeath?.Invoke();
        }
    }
    public void PlayerTakeDamage(int damageAmount)
    {
        if (playerAlive)
        {
            currentHealth -= damageAmount;
            healthBar.SetCurrentHealth(currentHealth, maxHealth);
        }
    }
}

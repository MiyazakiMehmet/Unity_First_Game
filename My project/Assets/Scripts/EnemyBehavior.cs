using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private PlayerBehavior playerBehavior;
    [SerializeField] private EnemyHealthBarScript enemyHealthBar;

    public int currentHealth;
    public int maxHealth = 300;
    public bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        enemyHealthBar.SetEnemyCurrentHealth(currentHealth, maxHealth);
    }

    void Update()
    {
        if(currentHealth > 0)
        {
            isAlive = true;
        }
        else
        {
            isAlive = false;
            Destroy(gameObject);
            playerBehavior.killCount++;
        }
    }

    public void EnemyTakeDamage(int damageAmount)
    {
        if (isAlive)
        {
            currentHealth -= damageAmount;
            enemyHealthBar.SetEnemyCurrentHealth(currentHealth, maxHealth);
        }
    }
}


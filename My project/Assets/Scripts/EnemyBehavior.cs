using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private EnemyHealthBarScript enemyHealthBar;

    public int currentHealth;
    public int maxHealth = 300;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        enemyHealthBar.SetEnemyCurrentHealth(currentHealth, maxHealth);
    }

    public void EnemyTakeDamage(int damageAmount)
    {
        if (currentHealth > 0)
        {
            currentHealth -= damageAmount;
            enemyHealthBar.SetEnemyCurrentHealth(currentHealth, maxHealth);
            
        }
        else if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}


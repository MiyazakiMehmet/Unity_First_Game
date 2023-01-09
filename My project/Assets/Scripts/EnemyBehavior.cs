using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 300;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void EnemyTakeDamage(int damageAmount)
    {
        if (currentHealth > 0)
        {
            currentHealth -= damageAmount;
        }
        else if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}

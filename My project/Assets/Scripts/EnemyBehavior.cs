using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public int attackDamage;

    // Start is called before the first frame update
    void Start()
    {
        SetInitialHealth(GameManager.gameManager.enemyHealth.health);
    }

    void Update()
    {
    }

    void SetInitialHealth(int initialHealth)
    {
        maxHealth = initialHealth;
        currentHealth = initialHealth;
    }

}

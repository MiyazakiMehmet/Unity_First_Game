using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private HealtBarScript healthBar;

    public int currentHealth;
    public int maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void PlayerTakeDamage(int damageAmount)
    {
        if (currentHealth > 0)
        {
            currentHealth -= damageAmount;
            healthBar.SetCurrentHealth(currentHealth);
        }
        else if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}

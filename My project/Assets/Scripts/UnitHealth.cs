using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth
{
    int currentHealth;
    int maxHealth;

    public int health
    {
        get
        {
            return currentHealth;
        }
        set
        {
            currentHealth = value;
        }
    }

    public UnitHealth(int currentHealth, int maxHealth)
    {
        this.currentHealth = currentHealth;
        this.maxHealth = maxHealth;
    }

    public void DamageUnit(int damageAmount)
    {
        if(currentHealth > 0)
        {
            currentHealth -= damageAmount;
        }
    }
}

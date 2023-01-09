using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 300;
    public int attackDamage = 25;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = currentHealth;
    }

}

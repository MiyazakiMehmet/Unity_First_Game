using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBarScript : MonoBehaviour
{
    public Slider EnemyHealthBar;
    public Color High;
    public Color Low;

    void Update()
    {
        //Makes Healthbar stable in one Axis
        transform.rotation = Quaternion.identity;
    }

    public void SetEnemyCurrentHealth(int currentHealth, int maxHealth)
    {
        //Shows bar only if currentHealth goes below than maxHealth
        EnemyHealthBar.gameObject.SetActive(currentHealth < maxHealth);

        EnemyHealthBar.value = currentHealth;
        EnemyHealthBar.maxValue = maxHealth;

        EnemyHealthBar.fillRect.GetComponentInChildren<Image>().color =
            Color.Lerp(Low, High, EnemyHealthBar.normalizedValue);
    }


}

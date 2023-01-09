using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtBarScript : MonoBehaviour
{
    Slider HealthBarSlider;

    void Start()
    {
        HealthBarSlider = GetComponent<Slider>();
    }

    public void SetMaxHealth(int MaxHealth)
    {
        HealthBarSlider.maxValue = MaxHealth;
        HealthBarSlider.value = MaxHealth;
    }

    public void SetCurrentHealth(int CurrentHealth)
    {
        HealthBarSlider.value = CurrentHealth;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtBarScript : MonoBehaviour
{
    Slider HealthBarSlider;
    public Color High;
    public Color Low; 

    void Start()
    {
        HealthBarSlider = GetComponent<Slider>();
    }

    public void SetCurrentHealth(int CurrentHealth, int MaxHealth)
    {
        HealthBarSlider.value = CurrentHealth;
        HealthBarSlider.maxValue = MaxHealth;
        HealthBarSlider.fillRect.GetComponentInChildren<Image>().color =
    Color.Lerp(Low, High, HealthBarSlider.normalizedValue);
    }
}

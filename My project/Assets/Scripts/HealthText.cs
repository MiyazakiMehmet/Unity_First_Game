using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    [SerializeField] private PlayerBehavior playerBehavior;
    public Text healthText;

    void Start()
    {
        healthText.text = playerBehavior.currentHealth.ToString();
    }

    void Update()
    {
        healthText.text = playerBehavior.currentHealth.ToString();
    }
}

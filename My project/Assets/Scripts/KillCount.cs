using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillCount : MonoBehaviour
{
    [SerializeField] private PlayerBehavior playerBehavior;
    public TMP_Text killCountText;

    void Start()
    {
        killCountText.text = "Kill Count : " + playerBehavior.killCount.ToString();
    }

    void Update()
    {
        killCountText.text = "Kill Count : " + playerBehavior.killCount.ToString();
    }
}

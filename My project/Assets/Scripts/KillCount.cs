using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillCount : MonoBehaviour
{
    [SerializeField] private PlayerBehavior playerBehavior;
    public TMP_Text killCountText, maxKillCountText;
    public int maxKillCount;

    public GameObject NewRecordText;

    void Start()
    {
        maxKillCount = PlayerPrefs.GetInt("maxKillCount", maxKillCount);
        killCountText.text = "Kill Count : " + playerBehavior.killCount.ToString();
    }

    void Update()       
    {
        if(playerBehavior.killCount > maxKillCount)
        {
            NewRecordText.SetActive(true);
            maxKillCount = playerBehavior.killCount;
        }
        killCountText.text = "Kill Count : " + playerBehavior.killCount.ToString();
        if(playerBehavior.playerAlive == false)
        {
            maxKillCountText.text = "Highscore : " + maxKillCount.ToString();
        }
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("maxKillCount", maxKillCount);
        PlayerPrefs.Save();
    }
}

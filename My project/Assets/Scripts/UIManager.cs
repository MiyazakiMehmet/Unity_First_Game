using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverMenu;

    //Actions
    void OnEnable()
    {
        PlayerBehavior.playerDeath += EnableGameOverMenu;
    }

    void OnDisable()
    {
        PlayerBehavior.playerDeath -= EnableGameOverMenu;
    }

    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }
}

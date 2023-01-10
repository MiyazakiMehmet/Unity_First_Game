using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverMenu;

    //Subscribing to Event
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

    public void RestartLevel()
    {
        SceneManager.LoadScene("GameScene");
    }
}

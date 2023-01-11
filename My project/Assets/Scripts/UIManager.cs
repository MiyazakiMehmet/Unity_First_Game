using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject killCountText;

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
        killCountText.SetActive(false);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("GameScene");
    }
}

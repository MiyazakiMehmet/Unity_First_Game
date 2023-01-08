using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager { get; private set; }

    //You can access UnitHealth instances from here
    public UnitHealth playerHealth = new UnitHealth(100, 100);
    public UnitHealth enemyHealth = new UnitHealth(60, 60);

    void Awake()
    {
        if(gameManager != null && gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimRod : MonoBehaviour
{
    private Transform aimTransform;

    void Awake()
    {
        aimTransform = transform.Find("Aim");
    }
    
    void Update()
    {
        
    }

}


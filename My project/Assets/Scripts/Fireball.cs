using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public float bulletSpeed;
    private bool isFacingUp;

    void Start()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isFacingUp = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            isFacingUp = false; 
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * bulletSpeed;
        }
        else if (isFacingUp)
        {
            rb.velocity = transform.up * bulletSpeed;
        }
        else if (!isFacingUp)
        {
            rb.velocity = -transform.up * bulletSpeed;
        }
    }
}

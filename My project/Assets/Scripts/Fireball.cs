using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public float bulletSpeed;


    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;
    }

}

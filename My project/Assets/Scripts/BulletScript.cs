using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject particle;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject Effect = Instantiate(particle, transform.position, Quaternion.identity);
        Destroy(Effect, 0.4f);
        Destroy(gameObject);
    }
}

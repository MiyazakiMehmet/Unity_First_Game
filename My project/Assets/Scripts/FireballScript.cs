using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class FireballScript : MonoBehaviour
{
    public GameObject particle;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            GameObject Effect = Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(Effect, 0.4f);
            Destroy(gameObject);
        }
    }
}

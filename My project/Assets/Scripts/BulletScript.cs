using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int attackDamage;

    public GameObject particle;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject Effect = Instantiate(particle, transform.position, Quaternion.identity);
        Destroy(Effect, 0.4f);
        Destroy(gameObject);
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerBehavior>().PlayerTakeDamage(attackDamage);
        }
        Physics2D.IgnoreLayerCollision(9,8);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private EnemyFollow enemyFollow;
    Rigidbody2D rbBullet;
    public float bulletSpeed;
    public Transform BulletPoint;
    public GameObject BulletPrefab;
    public Transform Character;

    void Update()
    {
        if (enemyFollow.detected)
        {
            Shoot();
        }
    }

    void FixedUpdate()
    {
        if (enemyFollow.detected)
        {
            float angle = Mathf.Atan2(Character.position.y, Character.position.x)
                * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
    }

    void Shoot()
    {
        GameObject Bullet = Instantiate(BulletPrefab, BulletPoint.position, BulletPoint.rotation);
        rbBullet = Bullet.GetComponent<Rigidbody2D>();
        rbBullet.AddForce(BulletPoint.up * bulletSpeed, ForceMode2D.Impulse);
    }

}

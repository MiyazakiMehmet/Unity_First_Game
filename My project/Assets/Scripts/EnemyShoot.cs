using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private EnemyFollow enemyFollow;
    [SerializeField] private PlayerBehavior playerBehavior;
    Rigidbody2D rbBullet;
    public float bulletSpeed;
    public Transform BulletPoint;
    public GameObject BulletPrefab;
    public Transform Character;
    private bool isFacingRight;

    //AttackDamage
    public int attackDamage;

    //Cooldown
    private float shootCounter = 0f;
    public float shootCooldown = 0.3f;

    void Update()
    {
        if (enemyFollow.detected && playerBehavior.playerAlive)
        {
            Shoot();
            Flip();
        }
    }

    void FixedUpdate()
    {
        if (enemyFollow.detected && playerBehavior.playerAlive)
        {
            Vector3 targetDirection = Character.position - BulletPoint.position;
            float angle = Mathf.Atan2(targetDirection.y, targetDirection.x)
                * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
    }

    void Shoot()
    {
        if (Time.time > shootCounter + shootCooldown)
        {
            GameObject Bullet = Instantiate(BulletPrefab, BulletPoint.position, BulletPoint.rotation);
            rbBullet = Bullet.GetComponent<Rigidbody2D>();
            rbBullet.AddForce(BulletPoint.right * bulletSpeed, ForceMode2D.Impulse);
            shootCounter = Time.time;
        }
    }

    void Flip()
    {
        if (Character.position.x >= enemyFollow.transform.position.x && isFacingRight ||
            Character.position.x < enemyFollow.transform.position.x && !isFacingRight)
        {
            isFacingRight = !isFacingRight;
            Vector3 FlipWeapon = transform.localScale;
            FlipWeapon.y *= -1f;
            transform.localScale = FlipWeapon;
        }
    }
}

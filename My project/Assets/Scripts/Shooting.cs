using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    Rigidbody2D rbFireball;
    public Transform FirePoint;
    public GameObject FireballPrefab;
    public float fireballSpeed;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void FixedUpdate()
    {
        Vector3 targetDirection = playerMovement.mousePos - FirePoint.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg  - 90f;
        FirePoint.transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    void Shoot()
    {
        GameObject Fireball = Instantiate(FireballPrefab, FirePoint.position, FirePoint.rotation);
        rbFireball = Fireball.GetComponent<Rigidbody2D>();
        rbFireball.AddForce(FirePoint.up * fireballSpeed, ForceMode2D.Impulse);
    }

}

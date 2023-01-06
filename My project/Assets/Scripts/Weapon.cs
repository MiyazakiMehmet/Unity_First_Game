using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject FireballPrefab;
    [SerializeField] private PlayerMovement playerMovement;

    public Transform FireballPointHorizontal;
    public Transform FireballPointVertical;
    private float AttackCounter = 0f;
    private float AttackCooldown = 0.8f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Attacking();
    }
    void Attacking()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > AttackCounter + AttackCooldown)
        {
            AttackCounter = Time.time;
            animator.SetBool("isAttacking", true);
            Shoot();
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    void Shoot()
    {
        if (playerMovement.xAxisZero && !playerMovement.isFacingUp)
        {
            Instantiate(FireballPrefab, FireballPointVertical.position, FireballPointVertical.rotation);
        }
        else if(playerMovement.xAxisZero && playerMovement.isFacingUp)
        {
            Instantiate(FireballPrefab, FireballPointVertical.position, FireballPointVertical.rotation);

        }
        else
        {
            Instantiate(FireballPrefab, FireballPointHorizontal.position, FireballPointHorizontal.rotation);
        }
    }
}

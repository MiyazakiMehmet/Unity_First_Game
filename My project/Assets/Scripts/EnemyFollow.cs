using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    //Instance
    PlayerBehavior playerBehavior;

    public Animator animator;
    public float movementSpeed;
    public bool detected = false;
    public float minimumDistance;
    public float maximumDistance;
    private bool isFacingRight;

    private Transform target;
    
    //Weapon Shown
    public GameObject Weapon;
    private bool weaponShow = false;

    void Start()
    {
        playerBehavior = PlayerBehavior.Instance;

        //Creating a gameobject reference since it will be accessable through prefabs
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (playerBehavior.playerAlive)
        {
            if (Vector2.Distance(transform.position, target.position) <= maximumDistance)
            {
                detected = true;
                animator.SetBool("Detected", true);
                weaponShow = true;
            }
            if (Vector2.Distance(transform.position, target.position) > minimumDistance && detected)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position,
                    movementSpeed * Time.deltaTime);
            }
            else if (Vector2.Distance(transform.position, target.position) <= minimumDistance && detected)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position,
                    -movementSpeed * Time.deltaTime);
            }
            if (detected)
            {
                Flip();
            }
        }
        else
        {
            animator.SetBool("Detected", false);
            weaponShow = false; 
        }   
        Weapon.SetActive(weaponShow);

    }

    void Flip()
    {
        if (target.position.x >= transform.position.x && isFacingRight ||
            target.position.x < transform.position.x && !isFacingRight)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0f, 180f, 0f);
        }
    }
}

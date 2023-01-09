using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Animator animator;
    public float movementSpeed;
    public bool detected = false;
    public Transform target;
    public float minimumDistance;
    public float maximumDistance;
    private bool isFacingRight;
    
    //Weapon Shown
    public GameObject Weapon;
    private bool weaponShow = false;

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) <= maximumDistance)
        {
            detected = true;
            animator.SetBool("Detected", true);
            weaponShow = true;
        }
        if (Vector2.Distance(transform.position, target.position) > minimumDistance && detected) {
            transform.position = Vector2.MoveTowards(transform.position, target.position,
                movementSpeed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, target.position) <= minimumDistance && detected){
            transform.position = Vector2.MoveTowards(transform.position, target.position,
                -movementSpeed * Time.deltaTime);
        }
        if (detected)
        {
            Flip();
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

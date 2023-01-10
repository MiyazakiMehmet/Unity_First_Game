using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform Rod;
    public Camera cam;
    Vector2 move;
    public Vector3 mousePos;
    //Rod
    Vector3 newPosition;
    
    public float movementSpeed;
    public bool isFacingRight = true;
    public bool isFacingUp = false;
 
    //Animation
    public Animator animator;

    void Start()
    {
        EnablePlayerMovement();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //Rod x Axis Reverse
        newPosition = Rod.transform.localPosition;
        newPosition.x *= -1f;

    }

    void FixedUpdate()
    {
        //Movement
        rb.velocity = new Vector2(move.x * movementSpeed * Time.deltaTime, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, move.y * movementSpeed * Time.deltaTime);
    }

    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw ("Vertical"));

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);    

        Movement();
    }

    void Movement()
    {
        if (mousePos.y > transform.position.y)
        {
            isFacingUp = true;
            animator.SetBool("isFacingUp", true);
        }
        else if (mousePos.y <= transform.position.y)
        {
            isFacingUp = false;
            animator.SetBool("isFacingUp", false);
        }

        //Changing x Axis of Rod
        if(mousePos.x < transform.position.x)
        {

            Rod.transform.localPosition = newPosition;
        }
        else
        {
            Rod.transform.localPosition = -newPosition;
        }
    }

    //Subscribing to Event
    void OnEnable()
    {
        PlayerBehavior.playerDeath += DisablePlayerMovement;
    }

    void OnDisable()
    {
        PlayerBehavior.playerDeath -= DisablePlayerMovement;
    }

    void DisablePlayerMovement()
    {
        animator.enabled = false;
        rb.bodyType = RigidbodyType2D.Static;
    }

    void EnablePlayerMovement()
    {
        animator.enabled = true;
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}

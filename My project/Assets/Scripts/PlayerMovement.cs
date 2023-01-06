using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    Vector2 move;
    public float movementSpeed;
    public bool isFacingRight = true;
    public bool isFacingUp = false;
    public bool xAxisZero;

    //Jumping
    public float jumpingPower;
    public Transform GroundCheck;
    [SerializeField] private float GroundCheckRadius;
    [SerializeField] private LayerMask GroundLayer;
    private bool isGrounded;

    //Animation
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
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

        Movement();
        Flip();
    }

    void Movement()
    {
        animator.SetFloat("xVelocity", Mathf.Abs(move.x));
        animator.SetFloat("yVelocity", move.y);
        if (Input.GetKey(KeyCode.W))
        {
            isFacingUp = true;
            animator.SetBool("isFacingUp", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            isFacingUp = false;
            animator.SetBool("isFacingUp", false);
        }
        if (isFacingUp && Mathf.Abs(move.x) > 0.1f && !Input.GetKey(KeyCode.W))
        {
            isFacingUp = false;
            animator.SetBool("isFacingUp", false);
        }
        if(move.x == 0)
        {
            xAxisZero = true;
        }
        else
        {
            xAxisZero = false;
        }
    }

    //Horizontal Character Flip
    void Flip()
    {
        if(isFacingRight && move.x < 0.1f || !isFacingRight && move.x > 0.1f)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0f, 180f, 0f);
        }
    }
}

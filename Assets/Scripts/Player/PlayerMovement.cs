using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private TrailRenderer trailRenderer;
    private Animator animator;
    public TimeLostController timeLostController;

    [Header("Ground Check Variables")]
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    private bool isFacingRight = true;

    public bool isGrounded = true;


    [Header("Movement Variables")]
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpingPower = 15f;
    private float horizontal; 


    [Header("Dashing Variables")]
    [SerializeField] private float dashingVelocity = 18f;
    [SerializeField] private float dashingTime = 0.75f;
    [SerializeField] private float dashingCooldown = 1f;
    private Vector2 dashingDirection;
    private bool isDashing;
    private bool canDash = true;
    private bool dashInput;


    void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
        animator = GetComponent<Animator>();
        transform.localScale = new Vector3(8f, 8f, 1f);
        timeLostController.TimeLostDisplay.SetActive(false);

        animator.SetBool("isGrounded", true);
    }

    void Update()
    {
        Debug.Log($"Speed: {Mathf.Abs(horizontal)}, IsGrounded: {IsGrounded()}"); // Debug log

        horizontal = Input.GetAxisRaw("Horizontal");
        dashInput = Input.GetButtonDown("Dash");

        animator.SetBool("isGrounded", IsGrounded());
        isGrounded = IsGrounded();
        animator.SetBool("isGrounded", isGrounded); 
        
        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            animator.SetBool("isGrounded", IsGrounded());
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f) 
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        if (Input.GetButtonDown() && canDash = true)
        {
            StartCoroutine(Dash());
        }

        if (isDashing)
        {
            rb.velocity = dashingDirection.normalized * dashingVelocity;
            return;
        }

        if (IsGrounded())
        {
            canDash = true;
        }   

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingVelocity, 0f);
        trailRenderer.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        trailRenderer.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
        animator.SetBool("IsDashing", isDashing);
    }
    

    private IEnumerator StopDashing()
    {
        yield return new WaitForSeconds(dashingTime);
        trailRenderer.emitting = false;
        isDashing = false;
    }


    public bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
} 

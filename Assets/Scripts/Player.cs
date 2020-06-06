﻿using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 8f;

    [SerializeField]
    private float jumpForce = 22f;

    [SerializeField]
    private float fallMultiplier = 1.6f;

    [SerializeField]
    private Transform balloonPrefab;

    private Rigidbody2D rb = null;
    private Vector2 moveDir = new Vector2();

    private void Awake()
    {
        //controls = new Player1Input();
        rb = this.GetComponent<Rigidbody2D>();
        Debug.Assert(rb != null, "Rigidbody missing");
    }

    public void OnMove(InputValue input)
    {
        moveDir = input.Get<Vector2>();
    }

    public void OnJump(InputValue input)
    {
        if (input.isPressed && isPlayerGrounded()) rb.velocity += new Vector2(0, jumpForce);
    }

    public void OnInteract(InputValue input)
    {
        if (input.isPressed)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.6f, LayerMask.GetMask("Ground"));
            if (hit)
            {
                Debug.Log(hit.transform.position);
                Debug.DrawRay(hit.point, Vector2.down, Color.green, 2f);
                SpawnBalloon(hit.point);
            }
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDir * moveSpeed);
        rb.velocity = new Vector2(moveDir.x * moveSpeed, rb.velocity.y);

        // falling
        if (rb.velocity.y < 0)
        {
            rb.velocity += Time.fixedDeltaTime * rb.gravityScale * Physics2D.gravity * (fallMultiplier);
        }
    }

    private bool isPlayerGrounded()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, 0.6f, LayerMask.GetMask("Ground"));
    }

    private void SpawnBalloon(Vector2 origin)
    {
        Debug.Assert(balloonPrefab != null, "No prefab chosen in Inspector");
        Instantiate(balloonPrefab, origin, Quaternion.identity, transform.parent);
    }
}
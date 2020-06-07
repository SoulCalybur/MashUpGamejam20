using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 8f;

    [SerializeField]
    private float jumpForce = 22f;

    [SerializeField]
    private float fallMultiplier = 1.6f;


    private Rigidbody2D rb = null;
    private Vector2 moveDir = new Vector2();

    private void Awake() {
        rb = this.GetComponent<Rigidbody2D>();
        Debug.Assert(rb != null, "Rigidbody missing");
    }

    public void OnMove(InputValue input) {
        moveDir = input.Get<Vector2>();
    }

    public void OnJump(InputValue input) {
        if (input.isPressed && isPlayerGrounded()) rb.velocity += new Vector2(0, jumpForce);
    }

    private void FixedUpdate() {
        rb.AddForce(moveDir * moveSpeed);
        rb.velocity = new Vector2(moveDir.x * moveSpeed, rb.velocity.y);

        // falling
        if (rb.velocity.y < 0) {
            rb.velocity += Time.fixedDeltaTime * rb.gravityScale * Physics2D.gravity * (fallMultiplier);
        }
    }

    private bool isPlayerGrounded() {
        // choosing layermask gets all objects on this layer
        return Physics2D.Raycast(transform.position, Vector2.down, 0.6f, LayerMask.GetMask("Ground"));
    }

    
}
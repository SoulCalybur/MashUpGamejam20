using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatVelocityApplier : MonoBehaviour
{

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("entering trigger function");
        if (other.transform.CompareTag("MoveableObject"))
        {
            other.attachedRigidbody.velocity += new Vector2(rb.velocity.x,0);
            Debug.Log("Velocity of object: "+other.attachedRigidbody.velocity);
        }
    }
    

    
}

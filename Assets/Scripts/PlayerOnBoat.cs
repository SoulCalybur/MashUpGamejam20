using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnBoat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Vector PlayerPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D hit;

        hit = Physics2D.Raycast(transform.position, -Vector2.up);

        if (hit.collider == null)
            return;

        if(hit.collider.CompareTag("MovablePlatform"))
        {

        }
    }
}

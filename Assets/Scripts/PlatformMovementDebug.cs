using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementDebug : MonoBehaviour
{

    public int speed = 2;
    // Start is called before the first frame update

    Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right  * speed;
    }

    // Update is called once per frame
    


    void Update()

    {
        //transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}

using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

   

    private Rigidbody2D PlayerRigidbody;

    public bool FacingRight;

    public ArmRotation _Arm;

    private bool _Grounded;

    [SerializeField]  private LayerMask whatIsGround;

    [SerializeField]  private Transform[] groundPoints;

    private bool _Jump;

    public float jumpHight;

    public float _Speed;

    public float _Horizontal;

    void Awake ()

    {
        

        PlayerRigidbody = gameObject.GetComponent<Rigidbody2D>();

        FacingRight = true;

    }

	void Start ()

    {
	
        

	}
	

    void FixedUpdate ()

    {

        float _Horizontal = Input.GetAxis("Horizontal");

        float _Vertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
        {
            PlayerRigidbody.AddForce(transform.up*20);
        }

            Movements(_Horizontal);

      
    }

	void Update ()

    {
	
	}

    void Movements (float _Horizontal)

    {

            PlayerRigidbody.AddForce(new Vector2(_Speed*_Horizontal, PlayerRigidbody.velocity.y));


    }

  

    public void TurnCharacter ()

    {

        
            FacingRight = !FacingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1f;

            transform.localScale = theScale;
        

    }
}

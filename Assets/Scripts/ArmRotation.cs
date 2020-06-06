using UnityEngine;
using System.Collections;

public class ArmRotation : MonoBehaviour

{
    public Transform hitPoint;

    public Transform CursorPoint;

    public bool direction;

    public PlayerScript p_Script;

    public Camera cam;

    public int posOffset;

    void Start()

    {

        direction = true;

    }

    void Update()

    {
       




        //rotation
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5f;

        //mouse position in world space
        Vector3 CursorInputRaw = new Vector3(mousePos.x, mousePos.y, 0);
        Vector3 CursorInput = cam.ScreenToWorldPoint(CursorInputRaw);

        Vector3 objectPos = cam.WorldToScreenPoint(transform.position);


        //Debug.Log(" Mouse pos: x:" + mousePos.x + ", y:" + mousePos.y);



        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;



        //Vector3 CursorInputRaw = new Vector3(mousePos.x, mousePos.y, 0);

        //Vector3 CursorInput = cam.ScreenToWorldPoint(CursorInputRaw);
        //Vector3 CursorInput = cam.ScreenToWorldPoint(CursorInputRaw+objectPos);

        CursorPoint.transform.position = new Vector3(CursorInput.x, CursorInput.y, 0);


        Debug.Log(CursorPoint.transform.position + ", Mouse pos: x:"+  mousePos.x+", y:"+ mousePos.y);
                                                                  
        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        //Debug.Log(angle + "");

        if (direction ==true) { posOffset = 75; }
        if (direction == false) { posOffset = 110; }

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + posOffset)); //Rotating!



        if (angle > 0f && angle < 100f || angle < 0f && angle > -90f)
        {
            if (direction == false)

            {
                direction = true;

                Flip();
            }
        }

        if (angle > 100f && angle < 180f || angle < -90f && angle > -180f)

            if (direction == true)

            {
                direction = false;

                Flip();
            }

    }

    void Flip()

    {
        if (direction == false && p_Script._Direction == true || direction == true && p_Script._Direction == false)

        { p_Script.Flipp(); }

        hitPoint.Rotate(Vector3.forward * 180);

        Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        

    }

}

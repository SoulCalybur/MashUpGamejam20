using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAim : MonoBehaviour
{
    private Vector2 mousePos = new Vector2();
    private Vector2 ownScreenPos = new Vector2();

    public void OnLook(InputValue input)
    {
        mousePos = input.Get<Vector2>();
        //Debug.Log(mousePos);
        Vector3 temp = Camera.main.WorldToScreenPoint(transform.position);
        Vector2 screenPos = new Vector2(temp.x, temp.y);

        Debug.Log("ScreenPos:" + screenPos + " --- " + mousePos + " --- " + (mousePos - screenPos));
    }
}
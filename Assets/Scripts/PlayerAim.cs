using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAim : MonoBehaviour {
    private Vector2 mousePos = new Vector2();
    private Vector2 playerScreenPos = new Vector2();
    private Vector2 lookDir = new Vector2();

    const float MAX_DIST = 50; //pixel units

    [SerializeField]
    RectTransform crosshair;

    private void Awake() {
        crosshair = crosshair.GetComponent<RectTransform>();
    }

    public void OnLook(InputValue input) {
        mousePos = input.Get<Vector2>();
    }

    void FixedUpdate() {
        Vector3 temp = Camera.main.WorldToScreenPoint(transform.position);
        playerScreenPos = new Vector2(temp.x, temp.y);

        lookDir = (mousePos - playerScreenPos);
        float distance = lookDir.magnitude;

        if (distance > MAX_DIST) {
            crosshair.position = playerScreenPos + lookDir.normalized * MAX_DIST;
        } else {
            crosshair.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInteraction : MonoBehaviour {

    [SerializeField]
    private Transform balloonPrefab = null;
    [SerializeField]
    private int balloonCapacity = 3;

    public void OnInteract(InputValue input) {
        if (input.isPressed && balloonCapacity > 0) {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.6f, LayerMask.GetMask("Ground"));
            if (hit) {
                Debug.Log("Balloon placed at: " + hit.transform.position);
                Debug.DrawRay(hit.point, Vector2.down, Color.green, 2f);
                SpawnBalloon(hit.point);
            }
        }
    }
    private void SpawnBalloon(Vector2 origin) {
        Debug.Assert(balloonPrefab != null, "No prefab chosen in Inspector");
        Debug.Assert(balloonCapacity > 0, "Not enough balloons left");
        Instantiate(balloonPrefab, origin, Quaternion.identity, transform.parent);
        balloonCapacity--;
        if(balloonCapacity < 0) balloonCapacity = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInteraction : MonoBehaviour {

    [SerializeField]
    private Transform balloonPrefab = null;
    [SerializeField]
    private int balloonCapacity = 3;

    private List<Transform> balloons = new List<Transform>();

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

    public void OnFire(InputValue input) {
        if (input.isPressed) {
            PumpUpBalloon();
        }
    }
    private void SpawnBalloon(Vector2 origin) {
        Debug.Assert(balloonPrefab != null, "No prefab chosen in Inspector");
        Debug.Assert(balloonCapacity > 0, "Not enough balloons left");
        balloons.Add(Instantiate(balloonPrefab, origin, Quaternion.identity, transform.parent));
        balloonCapacity--;
        if(balloonCapacity < 0) balloonCapacity = 0;
    }

    private void PumpUpBalloon() {
        Debug.Log("Pumping up all balloons");
        //foreach (Transform balloon in balloons) { // ERROR HERE
        //    int indexOfB = balloons.IndexOf(balloon);
        //    bool exploded = balloon.GetComponent<Balloon>().PumpUp(10);
        //}

        for (int i = 0; i < balloons.Count; i++) {
            bool exploded = balloons[i].GetComponent<Balloon>().PumpUp(10);
            if (exploded) balloons.RemoveAt(i--); // i-- because of removing item from currently iterating list
        }
    }

}

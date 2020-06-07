using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

    [SerializeField]
    private int curAirVolume = 10;
    private const int MAX_AIR_VOLUME = 100;

    [SerializeField]
    private Transform balloonSprite;

    public bool PumpUp(int amount) {
        Debug.Assert(amount > 0, "Negative balloon blowup-amount!");
        curAirVolume += amount;
        balloonSprite.localScale = new Vector3(balloonSprite.localScale.x * 1.1f, balloonSprite.localScale.y * 1.1f, 0);
        balloonSprite.GetComponent<SpriteRenderer>().color = new Color((float)curAirVolume / (float)MAX_AIR_VOLUME, 0,0);
        if(curAirVolume >= MAX_AIR_VOLUME) {
            curAirVolume = MAX_AIR_VOLUME;
            Explode();
            Despawn();
            return true;
        }
        return false;
    }

    public void PumpOut(int amount) {
        Debug.Assert(amount > 0, "Negative balloon blowup-amount!");
        curAirVolume -= amount;
        if (curAirVolume <= MAX_AIR_VOLUME) {
            curAirVolume = 0;
            Despawn();
        }
    }

    private void Explode() {
        Debug.Log("Balloon exploded!");
    }
    private void Despawn() {
        Debug.Log("Despawn Balloon");
        Destroy(this.gameObject);
    }

}

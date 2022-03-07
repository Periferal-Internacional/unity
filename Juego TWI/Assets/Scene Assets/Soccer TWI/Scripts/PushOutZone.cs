using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushOutZone : MonoBehaviour
{
    public SpriteRenderer ballSpriteRenderer;
    public Transform ballTransform;
    public Vector2 centerCoords;
    public float timeOut = 3;

    private float timeWithBall = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag != "Ball") return;
        timeWithBall = 0;
    }

    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag != "Ball") return;
        timeWithBall += 0.02f/timeOut;
        ballSpriteRenderer.color = new Color(1, 1-timeWithBall, 1-timeWithBall, 1);
        if(timeWithBall >= 1){
            ballTransform.position = centerCoords;
            ballSpriteRenderer.color = Color.white;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag != "Ball") return;
        ballSpriteRenderer.color = Color.white;
    }
}

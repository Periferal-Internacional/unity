using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_GoalKeeper : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 myPos = transform.position;
        float velX = (mousePos.x - myPos.x);
        float velY = (mousePos.y - myPos.y);
        rigidbody.velocity = new Vector2(velX, velY);
    }
}

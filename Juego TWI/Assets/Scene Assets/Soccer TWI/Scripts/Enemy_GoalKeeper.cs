using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_GoalKeeper : MonoBehaviour
{
    public Transform ballTransform;
    public Rigidbody2D rigidbody;
    public float minX = -5, maxX = 5;
    public float minY = -1, maxY = 1;
    public float stupidness = 0.3f;
    
    void Update()
    {
        Vector2 ballPos = ballTransform.position;
        Vector2 myPos = transform.position;
        float velX = (ballPos.x - myPos.x) / Random.Range(1, 1+stupidness);
        float velY = (ballPos.y - myPos.y) / Random.Range(1, 1+stupidness);
        if(myPos.x >= maxX && velX > 0) velX = 0;
        if(myPos.x <= minX && velX < 0) velX = 0;
        if(myPos.y >= maxY && velY > 0) velY = 0;
        if(myPos.y <= minY && velY < 0) velY = 0;
        rigidbody.velocity = new Vector2(velX, velY);
    }
}

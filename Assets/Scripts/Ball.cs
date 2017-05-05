using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed = 30;
    

	// Use this for initialization
	void Start () {
        //Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}

    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketHeight)
    {
        // ascii art:
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    public void Reset()
    {
        // reset the ball position and restart the ball movement
        transform.position = new Vector2(0, 0);
        Start(); // restart the ball 
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RacketLeft") {
            //Calculating the hit Factor 
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

            Vector2 dir = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (col.gameObject.name == "RacketRight") {
            //Calculating the hit Factor 
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }

    }

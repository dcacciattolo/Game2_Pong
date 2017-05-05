using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    // this is the player score
    public int scoreA = 0;
   

    // this is the canvas text box
    public Text scoreAText;
    

    protected int detectWall1;
    

    // when the script launches, get the number of active walls 
    private void Start()
    {
        detectWall1 = GameObject.FindGameObjectsWithTag("WallLeft").Length;
    }

    // when the ball hits a wall with a
    // trigger collider, do something
    void OnTriggerEnter(Collider c)
    {

        // check that the player has hit a sphere
        if (c.tag == "Ball")
        {
            Debug.Break();
            // increment the score when the capsule
            // hits the sphere
            scoreA += 1;

            // adjust the score on the canvas
            scoreAText.text = "" + scoreA;

            //disable the collider so it doesn't repeat 
            c.enabled = true;

            // destroy the ball so that the game will stop
            Destroy(c.gameObject);

            // show us the score in the console
            // Ctrl + Shift + C in Unity
            Debug.Log(scoreA);

        }      
    }
}

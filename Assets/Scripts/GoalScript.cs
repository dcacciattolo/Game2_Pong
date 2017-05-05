using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {

    [SerializeField]
    int attackingPlayer; // which player scores into this goal
    [SerializeField]
    GameManagerScript gameMan;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.transform.name == "Ball")
        {
            gameMan.GoalScored(attackingPlayer);
        }
    }
}

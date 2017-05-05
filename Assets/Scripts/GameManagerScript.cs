using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    int playerOneScore, playerTwoScore;
    [SerializeField]
    Ball ballScript;
    [SerializeField]
    Text scoreText;

    // Use this for initialization
    void Start () {
        playerOneScore = 0;
        playerTwoScore = 0;
    }

    public void GoalScored(int playerNumber)
    {
        // increase the score for whichever player scored
        if (playerNumber == 1)
            playerOneScore++;
        
        else if (playerNumber == 2)
            playerTwoScore++;

        // now check if the player has won
        if (playerOneScore == 2)
        {
            GameOver(1);
        }

        else if (playerTwoScore == 2)
        {
            GameOver(2);
        }

        UpdateScoreText();

    }

    void GameOver(int winner)
    {
        // this is called when a player reaches 3 points 

        // reset the scores
        playerOneScore = 0;
        playerTwoScore = 0;
        ballScript.Reset();
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "" + playerOneScore.ToString() + "    " + playerTwoScore.ToString() + "";
    }
}

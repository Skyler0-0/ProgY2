/*using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    private int scoreTeamA = 0;
    private int scoreTeamB = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddPoints("TeamA" + 1);
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            AddPoints("TeamB" + 1);
            
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Winner: " + GetWinner());
        }
    }
    void AddPoints(string team, int points)
    {
        if (team == "TeamA")
        {
            scoreTeamA += points;
            Debug.Log("TeamA gets " + points + "points. Current score:" + scoreTeamB);
        }
        else if(team == "TeamB")
        {
            scoreTeamB += points;
            Debug.Log("TeamB gets " + points + "points. Current score:" + scoreTeamB);
        }
    }
    int GetScore(string team)
    {
        if (team == "TeamA") 
    }

    string GetWinner()
    {

    }

    void ResetScores()
    {

    }
}
*/
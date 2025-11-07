using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    private int score = 0;
    public int lives = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddScore(int amount)
    {
        score += amount;
 
    }

    void LoseLife()
    {
        lives--;
        UpdateUI();
        Debug.Log("Lives Left: " + lives);

        if (lives > 0)
        {
            Debug.Log("Game Over!");
        }
    }

    void UpdateUI()
    {
        scoreText.text = "score: " + score;
        livesText.text = "Loves: " + lives;
    }
}

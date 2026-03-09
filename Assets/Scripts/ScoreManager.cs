using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScore(int points)
    {
        score += points;
        UpdateScore();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}

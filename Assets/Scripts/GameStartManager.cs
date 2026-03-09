using UnityEngine;
using TMPro;

public class GameStartManager : MonoBehaviour
{
    public TMP_Text startText;

    SpawnManager spawnManager;
    Shooting shooting;
    ScoreManager scoreManager;

    public bool gameStarted = false;

    void Start()
    {
        spawnManager = FindFirstObjectByType<SpawnManager>();
        shooting = FindFirstObjectByType<Shooting>();
        scoreManager = FindFirstObjectByType<ScoreManager>();

        ShowMessage("PRESS ENTER TO START", true);

        // Disable gameplay scripts until game starts
        spawnManager.enabled = false;
        shooting.enabled = false;
    }

    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
    }

    void StartGame()
    {
        gameStarted = true;
        ShowMessage("", false);
        scoreManager.ResetScore();
        spawnManager.enabled = true;
        shooting.enabled = true;
    }

    public void GameOver()
    {
        gameStarted = false;
        spawnManager.enabled = false;
        shooting.enabled = false;

        ShowMessage("GAME OVER\nPRESS ENTER TO START", true);
    }

    void ShowMessage(string message, bool active)
    {
        startText.text = message;
        startText.gameObject.SetActive(active);
    }
}
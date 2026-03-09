using UnityEngine;

public class MediaMove : MonoBehaviour
{
    GameStartManager gameStartManager;
    private float fallSpeed = 0.5f;

    void Start()
    {
        gameStartManager = FindFirstObjectByType<GameStartManager>();
    }

    void Update()
    {
        if (!gameStartManager.gameStarted)
        {
            return;
        }

        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        if (transform.position.y < 4.367f)
        {
            Destroy(gameObject);

            // Call GameOver method instead of directly changing text
            gameStartManager.GameOver();
        }
    }
}
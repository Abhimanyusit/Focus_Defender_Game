using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    Shooting shoot;
    ScoreManager scoreManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shoot = FindFirstObjectByType<Shooting>();
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            shoot.PlayPop();
            scoreManager.AddScore(1);
            Destroy(other.gameObject);   // destroy bullet
            Destroy(gameObject);         // destroy media cube
        }
    }

}

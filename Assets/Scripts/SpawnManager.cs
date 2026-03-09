using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] mediaPrefabs;

    private float spawnPosY = 8;

    private float startDelay = 1.0f;
    private float spawnInterval = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        InvokeRepeating(nameof(SpawnMedia), startDelay, spawnInterval);
    }

    void OnDisable()
    {
        CancelInvoke(); // stops spawning when game over
    }

    void SpawnMedia()
    {
        Vector3 spawnPos = new Vector3(Random.Range(1.0f, 2.9f), spawnPosY, 2.30f);
        int mediaCount = Random.Range(0, mediaPrefabs.Length);
        Instantiate(mediaPrefabs[mediaCount], spawnPos, mediaPrefabs[mediaCount].transform.rotation);
    }
}

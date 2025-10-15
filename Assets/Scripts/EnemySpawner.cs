using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnTimer = 3;

    public float nextSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextSpawn = Time.time + spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            nextSpawn = Time.time + spawnTimer;
        }
    }
}

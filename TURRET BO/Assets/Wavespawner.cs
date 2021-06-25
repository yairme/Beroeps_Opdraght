using UnityEngine;
using System.Collections;

public class Wavespawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnpoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 0.5f;

    private int WaveIndex = 0;
    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
    }
     IEnumerator SpawnWave ()
    {
       for (int i = 0; i < WaveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
            //afstand tussen de enemy's
        }
        
        WaveIndex++;
    }
    void SpawnEnemy ()
    {
        Instantiate(enemyPrefab, spawnpoint.position, spawnpoint.rotation);
    }
}

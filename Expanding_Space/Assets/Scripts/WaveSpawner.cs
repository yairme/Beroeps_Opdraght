using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    private GameManager GM;

    public int EnemiesAlive = 0;

    public Wave[] waves;

    public Transform spawnPoint;

    public float timeBetweenWaves = 60f;
    private float countdown = 6f;
    
    private int waveNumber = 0;

    void Start()
    {
        GM = GameObject.Find("GameMaster").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (EnemiesAlive > 0)
        {
            return;
        }

        if (countdown <= 0f)
        {
            if (GM.gameEnded)
                return;
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        Wave wave = waves[waveNumber];
            
        for (int i = 0; i < wave.count; i++)
        {
            Looping();
            yield return new WaitForSeconds(1f / wave.rate);
        }
        waveNumber++;

        if (waveNumber == waves.Length)
        {
            //LevelWin UI
            this.enabled = false;
        }
    }

    void Looping()
    {
        Wave wave = waves[waveNumber];

        for (int j = 0; j < wave.enemy.Length; j++)
        {
            SpawnEnemy(wave.enemy[j]);
        }
    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        EnemiesAlive++;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefabs;
    private float spanwRange = 9;
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject powerupPrefab;

    private void Start()
    {
        SpanwEnemyWave(waveNumber);
        Instantiate(powerupPrefab,GenerateSpanwposition(),powerupPrefab.transform.rotation);
    }
    private Vector3 GenerateSpanwposition()
    {
        float spawnPosX = Random.Range(-spanwRange, spanwRange);
        float spawnPosZ = Random.Range(-spanwRange, spanwRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
    public void SpanwEnemyWave(int enemeisToSpanw)
    {
        for (int i = 0; i < enemeisToSpanw; i++)
        {
            Instantiate(enemyPrefabs, GenerateSpanwposition(), enemyPrefabs.transform.rotation);
        }
    }
    private void Update()
    {
        enemyCount = FindObjectsOfType<Follow>().Length;
        if (enemyCount==0)
        {
            waveNumber++;
            SpanwEnemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpanwposition(), powerupPrefab.transform.rotation);
        }
    }
}

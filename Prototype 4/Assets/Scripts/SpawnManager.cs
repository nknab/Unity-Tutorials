using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float _spawnPos = 9;
    private int _enemyCount;
    private int _waveNumber = 1;

    public GameObject enemyPrefab_, powerupPrefab_;


    // Start is called before the first frame update
    void Start()
    {
        SpwanEnemyWave(_waveNumber);
        Instantiate(powerupPrefab_, GenerateSpawnPosition(), powerupPrefab_.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        _enemyCount = FindObjectsOfType<Enemy>().Length;

        if(_enemyCount == 0)
        {
            _waveNumber++;
            SpwanEnemyWave(_waveNumber);
            Instantiate(powerupPrefab_, GenerateSpawnPosition(), powerupPrefab_.transform.rotation);
        }
    }

    void SpwanEnemyWave(int _enemiesToSpawn_)
    {
        for (int i = 0; i < _enemiesToSpawn_; i++)
        {
            Instantiate(enemyPrefab_, GenerateSpawnPosition(), enemyPrefab_.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-_spawnPos, _spawnPos);
        float spawnPosZ = Random.Range(-_spawnPos, _spawnPos);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}

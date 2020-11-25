using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float _spawnPos = 9;

    public GameObject enemyPrefab_;

    // Start is called before the first frame update
    void Start()
    {
       
        Instantiate(enemyPrefab_, GenerateSpawnPosition(), enemyPrefab_.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-_spawnPos, _spawnPos);
        float spawnPosZ = Random.Range(-_spawnPos, _spawnPos);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}

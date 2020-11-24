using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float _startDelay = 2.0f;
    private float _repeatRate = 2.0f;
    private Vector3 _spawnPos = new Vector3(25, 0, 0);

    public GameObject obstaclePrefab_;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", _startDelay, _repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab_, _spawnPos, obstaclePrefab_.transform.rotation);
    }
}

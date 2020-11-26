using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float _lbZ = 1.0f;
    private float _ubZ = 6.0f;
    private float _startDelay = 1.0f;
    private float _barrierDelay = 5.0f;
    private float _tassCoinDelay = 10.0f;

    public GameObject[] barriers_;
    public GameObject tassCoin_;

    // Start is called before the first frame update
    void Start()
    {

        //InvokeRepeating("SpawnBarrier", _startDelay, _barrierDelay);
        //InvokeRepeating("SpawnTassCoin", _startDelay, _tassCoinDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBarrier()
    {
        //int index = Random.Range(0, barriers_.Length);
        int index = 0;
        Instantiate(barriers_[index], barriers_[index].gameObject.transform.position, barriers_[index].gameObject.transform.rotation);
    }

    void SpawnTassCoin()
    {
        float randomY = Random.Range(_lbZ, _ubZ);
        Vector3 spawnPos = new Vector3(5, randomY, 0);
        Instantiate(tassCoin_, spawnPos, tassCoin_.gameObject.transform.rotation);
    }
}

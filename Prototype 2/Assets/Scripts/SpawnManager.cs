/*
 * File: SpawnManager.cs
 * Project: Unity Junior Programmer Pathway - Prototype 2
 * File Created: Monday, 23rd November 2020 9:15:59 PM
 * Author: nknab
 * Email: bkojo21@gmail.com
 * Version: 1.0
 * Brief: 
 * -----
 * Last Modified: Monday, 23rd November 2020 9:21:21 PM
 * Modified By: nknab
 * -----
 * Copyright ©2020 nknab
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float _spawnRangeX = 20;
    private float _spawnRangeZ = 20;
    public GameObject[] animalPrefabs_;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnRangeZ);

            int animalIndex = Random.Range(0, animalPrefabs_.Length);
            // Launch projectile from player when Spacebar is pressed.

            Instantiate(animalPrefabs_[animalIndex], spawnPos, animalPrefabs_[animalIndex].transform.rotation);
        }

    }
}

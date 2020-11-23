/*
 * File: DestroyOutOfBounds.cs
 * Project: Unity Junior Programmer Pathway - Prototype 2
 * File Created: Monday, 23rd November 2020 8:55:44 PM
 * Author: nknab
 * Email: bkojo21@gmail.com
 * Version: 1.0
 * Brief: 
 * -----
 * Last Modified: Monday, 23rd November 2020 10:25:15 PM
 * Modified By: nknab
 * -----
 * Copyright ©2020 nknab
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _topBound = 40.0f;
    private float _lowerBound = -20.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > _topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < _lowerBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}

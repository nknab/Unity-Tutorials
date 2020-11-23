/*
 * File: DetectCollisions.cs
 * Project: Unity Junior Programmer Pathway - Prototype 2
 * File Created: Monday, 23rd November 2020 10:15:29 PM
 * Author: nknab
 * Email: bkojo21@gmail.com
 * Version: 1.0
 * Brief: 
 * -----
 * Last Modified: Monday, 23rd November 2020 10:25:09 PM
 * Modified By: nknab
 * -----
 * Copyright ©2020 nknab
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

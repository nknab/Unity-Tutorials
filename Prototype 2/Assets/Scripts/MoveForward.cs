/*
 * File: MoveForward.cs
 * Project: Unity Junior Programmer Pathway - Prototype 2
 * File Created: Monday, 23rd November 2020 8:28:09 PM
 * Author: nknab
 * Email: bkojo21@gmail.com
 * Version: 1.0
 * Brief: 
 * -----
 * Last Modified: Monday, 23rd November 2020 8:29:23 PM
 * Modified By: nknab
 * -----
 * Copyright ©2020 nknab
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed_ = 40.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed_);
    }
}

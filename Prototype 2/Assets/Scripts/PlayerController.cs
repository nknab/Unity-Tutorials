/*
 * File: PlayerController.cs
 * Project: Unity Junior Programmer Pathway - Prototype 2
 * File Created: Monday, 23rd November 2020 6:58:13 PM
 * Author: nknab
 * Email: bkojo21@gmail.com
 * Version: 1.0
 * Brief: 
 * -----
 * Last Modified: Monday, 23rd November 2020 7:03:36 PM
 * Modified By: nknab
 * -----
 * Copyright ©2020 nknab
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _xRange = 10.0f;
    private float _speed = 10.0f;
    private float _horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Making sure the player does not go out of bounds
        if (transform.position.x < -_xRange){
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > _xRange){
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }

        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalInput * Time.deltaTime * _speed);
    }
}

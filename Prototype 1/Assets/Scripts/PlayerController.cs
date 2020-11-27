/*
 * File: PlayerController.cs
 * Project: Unity Junior Programmer Pathway - Prototype 1
 * File Created: Sunday, 22nd November 2020 10:53:38 AM
 * Author: nknab
 * Email: bkojo21@gmail.com
 * Version: 1.0
 * Brief: Controller responsible for moving the vehicle.
 * -----
 * Last Modified: Sunday, 22nd November 2020 12:25:45 PM
 * Modified By: nknab
 * -----
 * Copyright ©2020 nknab
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declaring and initializing variables.
    [SerializeField] private float _speed = 15.0f;
    private float _turnSpeed = 45.0f;

    // Declaring variables.

    private float _horizontalInput ;
    private float _verticalInput;


    // Update is called once per frame
    void FixedUpdate()
    {
        // Obtain player controll inputs.
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        // Moves the Vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalInput);

        // Turn the vehicle.
        transform.Rotate(Vector3.up * Time.deltaTime * _turnSpeed * _horizontalInput);
    }
}

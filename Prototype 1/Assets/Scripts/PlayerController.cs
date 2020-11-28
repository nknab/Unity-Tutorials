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
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Declaring and initializing variables.
    private float _speed;
    private float _rpm;
    private float _horsePower = 30000.0f;
    private float _turnSpeed = 45.0f;

    private Rigidbody _playerRb;

    [SerializeField] GameObject _com;
    [SerializeField] TextMeshProUGUI _speedometerText;
    [SerializeField] TextMeshProUGUI _rpmText;

    [SerializeField] List<WheelCollider> _allWheels;

    // Declaring variables.

    private float _horizontalInput ;
    private float _verticalInput;

    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        _playerRb.centerOfMass = _com.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Obtain player controll inputs.
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");


        if (IsOnGorund())
        {
            // Moves the Vehicle forward.
            //transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalInput);
            _playerRb.AddRelativeForce(Vector3.forward * _horsePower * _verticalInput);
            _speed = Mathf.Round(_playerRb.velocity.magnitude * 2.237f);
            _speedometerText.SetText("Speed : " + _speed + "mph");

            _rpm = Mathf.Round((_speed % 30) * 40);
            _rpmText.SetText("RPM : " + _rpm);

            // Turn the vehicle.
            transform.Rotate(Vector3.up * Time.deltaTime * _turnSpeed * _horizontalInput);
        }


    }

    private bool IsOnGorund()
    {
        int wheelsOnGround = 0;
        foreach(WheelCollider wheel in _allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }
        return (wheelsOnGround == 4) ? true : false;
    }
}

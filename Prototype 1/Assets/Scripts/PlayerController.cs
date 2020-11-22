/*
 * File: PlayerController.cs
 * Project: Unity Junior Programmer Pathway - Prototype 1
 * File Created: Sunday, 22nd November 2020 10:53:38 AM
 * Author: nknab
 * Email: bkojo21@gmail.com
 * Version: 1.0
 * Brief: This controller is responsible for moving the vehicle.
 * -----
 * Last Modified: Sunday, 22nd November 2020 11:14:47 AM
 * Modified By: nknab
 * -----
 * Copyright ©2020 nknab
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the Vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}

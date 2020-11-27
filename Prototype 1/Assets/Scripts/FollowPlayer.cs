/*
 * File: FollowPlayer.cs
 * Project: Unity Junior Programmer Pathway - Prototype 1
 * File Created: Sunday, 22nd November 2020 11:33:27 AM
 * Author: nknab
 * Email: bkojo21@gmail.com
 * Version: 1.0
 * Brief: Controller responsible for moving the camera into Player's POV.
 * -----
 * Last Modified: Sunday, 22nd November 2020 12:25:13 PM
 * Modified By: nknab
 * -----
 * Copyright ©2020 nknab
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Camera offset
    private Vector3 _offset = new Vector3(-0.0f, 2.9f, 2.49f);

    public GameObject player_;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player_.transform.position + _offset;

    }
}

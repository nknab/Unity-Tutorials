﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private PlayerController _playerController;

    private float _speed= 30.0f;
    private float _leftBound = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_playerController.GetGameOver())
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }

        if(transform.position.x < _leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}

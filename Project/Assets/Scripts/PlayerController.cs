using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float _jumpForce = 700.0f;
    private bool _isOnGround, _gameOver = false;


    private Rigidbody _playerRB;
    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && _isOnGround && !_gameOver)
        {
            _playerRB.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _isOnGround = false;

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && !_gameOver)
        {

        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isOnGround = true;
        }
        else if (other.gameObject.CompareTag("Barrier"))
        {
            _gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}

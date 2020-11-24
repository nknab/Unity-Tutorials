using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerRb;
    private Animator _playerAnim;

    private float _jumpForce = 700.0f;
    private float _gravityModifier = 1.5f;
    private bool _isOnGround = true;
    private bool _gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= _gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isOnGround && !_gameOver)
        {
            _playerRb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _playerAnim = GetComponent<Animator>();
            _isOnGround = false;
            _playerAnim.SetTrigger("Jump_trig");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            _gameOver = true;
            Debug.Log("Game Over!");
            _playerAnim.SetBool("Death_b", true);
            _playerAnim.SetInteger("DeathType_int", 1);
            
        }
    }

    public bool GetGameOver()
    {
        return _gameOver;
    }
}

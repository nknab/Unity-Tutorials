using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _playerAnim;
    private AudioSource _playerAudio;


    private float _jumpForce = 600.0f;
    private bool _isOnGround, _gameOver, _powerUp = false;

    private float _gravityModifier = 1.5f;

    public AudioClip jumpSound_;


    private Rigidbody _playerRB;
    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody>();
        _playerAudio = GetComponent<AudioSource>();
        _playerAnim = GetComponent<Animator>();
        Physics.gravity *= _gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && _isOnGround && !_gameOver)
        {
            _playerRB.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            
            _playerAnim.SetBool("Jump_b", true);
            //_playerAudio.PlayOneShot(jumpSound_, 1.0f);
            _isOnGround = false;

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && !_gameOver)
        {
            //_playerAnim.SetBool("Crouch_b", true);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TassCoin"))
        {
            Destroy(other.gameObject);
            _powerUp = true;
        }
    }
}

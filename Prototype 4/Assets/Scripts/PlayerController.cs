using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 7.5f;
    private float _powerUpTimer = 10.0f;
    private float _powerUpStrength = 10f;

    private Vector3 _powerUpOffset = new Vector3(0, -0.35f, 0);

    private bool _hasPowerUp = false;

    private Rigidbody _playerRb;

    private GameObject _focalPoint;
    public GameObject powerUpIndicator_;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        _focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        _playerRb.AddForce(_focalPoint.transform.forward * _speed * forwardInput);
        powerUpIndicator_.transform.position = transform.position + _powerUpOffset;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            _hasPowerUp = true;
            powerUpIndicator_.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountDownRoutine());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && _hasPowerUp)
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

            enemyRb.AddForce(awayFromPlayer * _powerUpStrength, ForceMode.Impulse);
            Debug.Log("Player Collided with " + collision.gameObject + " with power up set to " + _hasPowerUp);
        }
    }

    IEnumerator PowerUpCountDownRoutine()
    {
        yield return new WaitForSeconds(_powerUpTimer);
        _hasPowerUp = false;
        powerUpIndicator_.gameObject.SetActive(false);
    }
}

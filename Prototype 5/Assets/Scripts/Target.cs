using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float _minSpeed = 12.0f;
    private float _maxSpeed = 16.0f;
    private float _maxTorque = 10.0f;
    private float _xRange = 4.0f;
    private float _ySpawnPos = -2.0f;

    private int[] _pointValue = { 15, 10, 5, -10 };

    private Rigidbody _targetRb;

    private GameManager _gameManager;

    public ParticleSystem explosionParticle_;

    // Start is called before the first frame update
    void Start()
    {
        _targetRb = GetComponent<Rigidbody>();
        _targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        _targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();

        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (_gameManager.GetIsGameActive())
        {
            Destroy(gameObject);
            Instantiate(explosionParticle_, transform.position, explosionParticle_.transform.rotation);

            int index = 0;

            switch (gameObject.name)
            {
                case "Good 1(Clone)":
                    index = 0;
                    break;
                case "Good 2(Clone)":
                    index = 1;
                    break;
                case "Good 3(Clone)":
                    index = 2;
                    break;
                case "Bad(Clone)":
                    index = 3;
                    break;
            }


            _gameManager.UpdateScore(_pointValue[index]);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        if (!(gameObject.name.Equals("Bad(Clone)")))
        {
            _gameManager.GameOver();
        }
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(_minSpeed, _maxSpeed);
    }

    private float RandomTorque()
    {
        return Random.Range(-_maxTorque, _maxTorque);
    }

    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-_xRange, _xRange), _ySpawnPos);
    }
}

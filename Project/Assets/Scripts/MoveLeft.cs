using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float _speed = .0f;
    private float _leftBound = -30.0f;

    private Rigidbody _objectRb;

    // Start is called before the first frame update
    void Start()
    {
        _objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _objectRb.AddForce(Vector3.left * _speed, ForceMode.Force);

        if(transform.position.x < _leftBound)
        {
            Destroy(gameObject);
        }
    }
}

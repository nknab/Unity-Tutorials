using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float _timeInterval = 5.0f;
    private float _timer = 0.0f;
    private int _direction = -1;
    private float _scale = 1.3f;
    private float _speed = 10.0f;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        Material material = Renderer.material;

        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }

    void Update()
    {
        _timer += Time.deltaTime;

        transform.Rotate(_speed * Time.deltaTime, 0.0f, 0.0f);

        transform.localScale = Vector3.one * _scale;
        transform.Translate(Vector3.forward * Time.deltaTime * _direction);



        if (_timer > _timeInterval)
        {
            _scale = Random.Range(1.0f, 5.0f);
            _speed = Random.Range(5.0f, 50.0f);
            _direction = Random.Range(-1, 2);
            _timer = 0.0f;

        }
    }
}

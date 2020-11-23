using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float _timeInterval = 2.0f;
    private float _timer = 0.0f;
   

    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && _timer > _timeInterval)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            _timer = 0.0f;
        }

    }
}

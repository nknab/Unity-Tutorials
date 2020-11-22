using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    // Camera offset
    private Vector3 _offset = new Vector3(55, 0, 0);

    public GameObject plane_;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane_.transform.position + _offset;
    }
}

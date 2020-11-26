using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float _spawnRate = 1.0f;

    public List<GameObject> targets_;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnRate);
            int index = Random.Range(0, targets_.Count);
            Instantiate(targets_[index]);
        }
    }
}

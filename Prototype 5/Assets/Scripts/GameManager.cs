using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int _score;

    private float _spawnRate = 1.0f;

    public List<GameObject> targets_;

    public TextMeshProUGUI scoreText_;

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

    public void UpdateScore(int _score_)
    {
        _score += _score_;
        scoreText_.text = "Score : " + _score;
    }
}

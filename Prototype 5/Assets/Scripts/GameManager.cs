
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int _score;

    private float _spawnRate = 5.0f;

    private bool _isGameActive;

    public List<GameObject> targets_;

    public TextMeshProUGUI scoreText_;
    public TextMeshProUGUI gameOverText_;

    public Button restartButton_;

    public GameObject titleScreen_;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator SpawnTarget()
    {
        while (_isGameActive)
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

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverText_.gameObject.SetActive(true);
        restartButton_.gameObject.SetActive(true);
        _isGameActive = false;
    }

    public bool GetIsGameActive()
    {
        return _isGameActive;
    }

    public void StartGame(int _diffficulty_)
    {
        _isGameActive = true;
        
        UpdateScore(0);
        titleScreen_.gameObject.SetActive(false);
        _spawnRate /= _diffficulty_;
        StartCoroutine(SpawnTarget());
    }
}

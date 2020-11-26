using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{

    private Button _button;

    private int[] _difficulty = { 1, 2, 3 };

    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(SetDifficulty);

        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SetDifficulty()
    {
        int index = 0;

        switch (gameObject.name)
        {
            case "Easy Button":
                index = 0;
                break;
            case "Medium Button":
                index = 1;
                break;
            case "Hard Button":
                index = 2;
                break;
        }
        _gameManager.StartGame(_difficulty[index]);
    }
}

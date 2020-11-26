using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonX : MonoBehaviour
{
    private Button button;
    private GameManagerX gameManagerX;
    private int[] _difficulty = { 1, 2, 3 };

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetDifficulty()
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
        Debug.Log(button.gameObject.name + " was clicked ="+ _difficulty[index]);
        gameManagerX.StartGame(_difficulty[index]);
    }



}

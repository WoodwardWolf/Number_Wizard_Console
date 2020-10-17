using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxGuess;
    int minGuess;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maxGuess = 1000;
        minGuess = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a Number");
        Debug.Log($"The Highest Number Aloud is: {maxGuess}");
        Debug.Log($"The Lowest Number Aloud is: {minGuess}");
        Debug.Log($"Is Your Number Higher or Lower than {guess}?");
        Debug.Log("Up Arrow = Higher, Down Arrow = Lower, Enter = Correct");
        maxGuess += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log($"Your Number Must be {guess}!");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (maxGuess + minGuess) / 2;
        Debug.Log($"Higher or Lower than {guess}?");
    }
}

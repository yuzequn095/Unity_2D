using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        //int max = 1000;
        //int min = 1;
        //int guess = 500;
        StartGame();

    }

    void StartGame()
    {
        //max = 1000;
        //min = 1;
        //guess = 500;
        /*
        Debug.Log("Welcome to Number Wizard");
        //print("Welcome to number wizard...");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        */

        //guess = (max + min) / 2;
        //guessText.text = guess.ToString();
        NextGuess();
        //max = max + 1;
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }
    // Update is called once per frame
    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log("Up Arrow key was pressed");
            min = guess;
            //guess = (max + min) / 2;
            //Debug.Log(guess);
            //Debug.Log("Is it higher or lower than..." + guess);
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log("Down Arrow key was pressed.");
            max = guess;
            //guess = (max + min) / 2;
            //Debug.Log(guess);
            //Debug.Log("Is it higher or lower than..." + guess);
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //Debug.Log("You hit the answer.");
            StartGame();
        }
    }
    */

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        //guess = (max + min) / 2;
        //Debug.Log("Is it higher or lower than..." + guess);
        guessText.text = guess.ToString();
    }
}

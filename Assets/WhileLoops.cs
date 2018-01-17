using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {

    private int guessingNumber;
    private int guesses = 0;
    // Use this for initialization
	void Start () {
        int lowNum = 0;
        int highNum = 10;
        int secretNumber = Random.Range(lowNum, highNum);
        while (guessingNumber != secretNumber)
        {
            guesses++;
            guessingNumber = Random.Range(lowNum, highNum);
            if (guessingNumber > secretNumber)
            {
                print(guessingNumber + " is too high! The secret number is lower! The range is from " +highNum+ " to " +lowNum+".");
                highNum = guessingNumber;
            }
            if (guessingNumber < secretNumber)
            {
                print(guessingNumber+ " is too low! The secret number is higher! The range is from " + highNum + " to " + lowNum + ".");
                lowNum = guessingNumber;
            }
            if (guessingNumber == secretNumber)
            {
                print("The secret number is " + secretNumber);
                print("It took " + guesses + " guesses to find this answer!");
                break;
            }
        }
        
	}
	
	
}

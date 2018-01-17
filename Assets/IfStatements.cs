using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    private int numberSeven = 7;
    private float luckyNumberSeven = 7.0f;
    private bool banana = false;
    private string yellow = "Give";
    private string unlucky = "Bad Things happen in threes";
    private float error = 4.04f;
    private bool apple = false;
    private int numberEight = 8;
    // Use this for initialization
    void Start()
    {
        //Starting If Statements, == checks to see if they are equal values
        if (numberSeven == numberEight)
        {
            print("That's immpossible...");
        }
        //greater than or equal to operator
        if (numberSeven >= luckyNumberSeven)
        {
            print("Never");
        }
        //less than or equal to
        if (numberSeven <= luckyNumberSeven)
        {
            print("Gonna");
            banana = true;
        }
        //checking to see if banana is true
        if (banana)
        {
            print(yellow);
            apple = true;
        }
        //checking to see if these values are equal
        if (luckyNumberSeven == numberEight)
        {
            print(unlucky);
        }
        //checking to see if apple is true, which was set true previously if banana was true
        if (apple)
        {
            print("You");
        }
        //does not equal operator
        if (apple != banana)
        {
            print("Dont mix your fruits!");
        }

        if (apple == banana)
        {
            print("Up");
        }
        //greater than operator
        if (numberSeven > luckyNumberSeven)
        {
            print("Some things were made equally!");
        }
        //less than operator
        if (numberSeven < numberEight)
        {
            print("Never gonna let you down...");
        }

        

    }
}

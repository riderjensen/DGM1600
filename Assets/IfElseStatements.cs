using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseStatements : MonoBehaviour {
    private int time = 15;
    private bool run = false;
    private double eat = 14.6;
	// Use this for initialization
	void Start () {
		if (time == 15)
        {
            print("Its 3pm!");
            run = true;
        }
        else
        {
            print("Keep working!");
        }
        if (run == true)
        {
            print("Book it!!");

        }
        else
        {
            print("Better lounge!");
        }
        if (eat == time)
        {
            print("Better take something to go!");
            time = 16;
            if (run == true)
            {
                print("Okay book it again!");
                time = 17;
            }
            else
            {
                print("Do you want to work out or not??");
            }
        }
        else
        {
            print("Take your time and eat!");
            run = true;
        }
        
        if (time <= 17)
        {
            print("Okay time is up, just go to bed now!");
        }
        else
        {
            print("Plenty of time, dont look at the clock!");
        }
	}
	
	
}

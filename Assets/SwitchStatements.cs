using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour {
    private int time = 7;
    private int yellowSub = 3;
    private string money = "yes please";
    private int classSession = 11;
    private string runTime = "working";
	// Use this for initialization
	void Start () {
        //switch for time
       switch (time)
        {
            case 8:
                print("The time is 8");
                break;
            case 9:
                print("The time is 9");
                break;
            default:
                print(time);
                
                break;
        }
        //switch for pie
        switch (yellowSub)
        {
            case 3:
                print("Yummy Pi!");
                break;
            default:
                print("We will all die without something good to eat!");
                break;
        }
        //switch for money
        switch (money)
        {
            case "I am broke":
                print("Go make some money!");
                break;
            case "I am flush!":
                print("Well then give some to me!");
                break;
            default:
                print("What is that good green stuff??");
                break;
        }
        switch (classSession)
        {
            case 10:
                print("We are not in session!");
                break;
            case 11:
                print("Class just started! Dont be late!");
                break;
            case 12:
                print("Class just ended! Get out of here!");
                break;
            default:
                print("Should you be doing homework??");
                break;
        }
        switch (runTime)
        {
            case "working":
                print("Okay we are running!");
                print(time);
                print(yellowSub);
                break;
            default:
                print("You broke it!");
                break;
        }

	}
	
	
}

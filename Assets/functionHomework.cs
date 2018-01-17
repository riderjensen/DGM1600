using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class functionHomework : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void currentDate () {
        string greeting;
        int hour = DateTime.Now.Hour;

        if (hour < 12)
            greeting = "Good Morning";
        else if (hour < 17)
            greeting = "Good Afternoon";
        else
            greeting = "Good Evening";

        print(string.Format("{0}, the current time is {1}.", greeting, DateTime.Now.ToLongTimeString()));
        print(string.Format("The current date is {0}.", DateTime.Now.ToLongDateString()));
		
	}
}

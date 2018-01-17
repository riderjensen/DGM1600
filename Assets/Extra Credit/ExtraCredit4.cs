using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraCredit4 : MonoBehaviour {
    string newFloat = "34.45";
	// Use this for initialization
	void Start () {
        float newString = (newFunction(newFloat));
        print(newString);
	}

    public float newFunction(string newFloat)
    {
        float newerFloat = float.Parse(newFloat);
        return newerFloat;
    }
	
	
}

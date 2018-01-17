using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraCredit : MonoBehaviour {
    float numberOne = 7.4f;
    float numberTwo = 5.3f;
    float numberThree = 3.3f;
	// Use this for initialization
	void Start () {
        float yellow = functionThing(numberOne, numberTwo, numberThree);
        print(yellow);
	}

    public float functionThing(float numberOne, float numberTwo, float numberThree)
    {
        float numberTotal = numberOne * numberTwo *numberThree;
        return numberTotal;
    }
	
	
}

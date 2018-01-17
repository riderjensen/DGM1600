using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraCredit5 : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        float numberOne = 2.3f;
        float numberTwo = 4.3f;

        float totalFloat = addingNumbers(numberOne, numberTwo);
        print(totalFloat);
    }
		

    public float addingNumbers(float numberOne, float numberTwo){
        float newFloat = numberOne + numberTwo;
        return newFloat;
    }
	
	
}

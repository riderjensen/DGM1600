using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraCredit2 : MonoBehaviour {
    private string[] color = { "blue", "yellow", "green", "purple", "red" };
    private string[] names = { "John", "Jerry", "Jonathan", "Jake", "Junior" };

    // Use this for initialization
    void Start () {
        print((names[Random.Range(1, names.Length)]) + "'s favorit color is" + (color[Random.Range(1, color.Length)]));
	}
	
	
}

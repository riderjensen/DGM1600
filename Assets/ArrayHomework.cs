using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayHomework : MonoBehaviour {

    private string[] adj1 = { "ugly", "nice", "gummy", "sweaty", "crazy"};
    private string[] occupation = {"farmer", "plumber", "worker", "bussiness man", "olympic sprinter" };
    private string[] adj2 = { "sweet", "cute", "yellow", "smelly", "angry"};
    private string[] verb1 = { "ran", "sprinted", "rolled", "flew", "pinched"};
    private string[] adverb = { "quickly", "warrily", "cowardly", "heroicly", "squirley" };
    private string[] verb3 = {"crying", "sobbing", "jumping", "sliding", "flexing" };
    private string[] adj3 = {"flaming", "hollering", "bleeding", "gold digging", "squinting" };
    private string[] Noun1 = {"fire", "tree", "banana", "gun", "match stick" };
    private string[] Noun2 = { "jacket", "shorts", "shirt", "socks", "hat"};
    private string[] Noun3 = { "skateboard", "bike", "car", "plane", "jetpack" };
    private int[] randomNumber1 = {1, 3, 5, 7, 9, 11 };
    private int[] randomNumber2 = {2, 100, 76, 34, 19, 11 };


    // Use this for initialization
    void Start() {
        print("The " + adj1[Random.Range(0, adj1.Length)] + " " + occupation[Random.Range(0, occupation.Length)] + " "+  
            verb1[Random.Range(0, verb1.Length)] + " the " + adj2[Random.Range(0, adj2.Length)] +" "+ Noun1[Random.Range(0, Noun1.Length)] +
            " to the " + adj3[Random.Range(0, adj3.Length)] + " " + Noun2[Random.Range(0, Noun2.Length)] +" "+ randomNumber1[Random.Range(0, randomNumber1.Length)] +
            " times. This truly shows the " + Noun3[Random.Range(0, Noun3.Length)] + " is the best mode of transportation. Not even "+
            randomNumber2[Random.Range(0, randomNumber2.Length)] + " " + occupation[Random.Range(0, occupation.Length)] +"'s could disprove it. Dont go " +
            verb3[Random.Range(0, verb3.Length)] + " to your mom about it."

            );
	}
	
	
}

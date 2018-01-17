using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListHomework : MonoBehaviour {

    //define variable
    public string animals = "i";
    private int secretNumber;
    //creating list
    public List<string> zooRoster = new List<string>();
    
    // Use this for initialization
    void Start () {
        
        //add to list for start
        zooRoster.Add("Feret");
        zooRoster.Add("Lion");
        zooRoster.Add("Tiger");
        zooRoster.Add("Bear");
        zooRoster.Add("Monkey");
        zooRoster.Add("Seal");
        zooRoster.Add("Canary");
        zooRoster.Add("Gorilla");
        zooRoster.Add("Elephant");
        zooRoster.Add("Reptiles");
        

        
               
	}
    //remove method
    public void Remove()
    {
        if (animals == "")
        {
            print("Please add an animal");
        }
        else
        {
            zooRoster.Remove(animals);
        }
    }
    //clear method
    public void Clear()
    {
        zooRoster.Clear();
    }
    //print method
    
    public void Print()
    {
            zooRoster.ForEach(print);

    }
    //add method
    public void add()
    {
        if (animals != "")
        {
            zooRoster.Add(animals);
        }
        if (animals == "")
        {
            print("Please add an animal");
        }
    }


}

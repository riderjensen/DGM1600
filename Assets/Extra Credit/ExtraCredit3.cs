using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraCredit3 : MonoBehaviour {

    public List<int> numbersList = new List<int>();

    // Use this for initialization
    void Start()
    {
        int randomNumber = Random.Range(1, 10);
        numbersList.Add(randomNumber);
    }
}

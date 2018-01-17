using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoop : MonoBehaviour {
    public List<string> animals;
    public List<string> dogs;
    public List<string> cats;
    // Use this for initialization
    void Start() {
        animals.Add("dog");
        animals.Add("cat");
        animals.Add("spider");
        animals.Add("cat");
        animals.Add("lion");
        animals.Add("tiger");
        animals.Add("bear");
        animals.Add("ferret");
        animals.Add("monkey");
        for (int i = 0; i < animals.Count; i++)
        {
            switch (animals[i])
            {
                case "cat":
                    cats.Add(animals[i]);
                    animals.Remove(animals[i]);
                    break;
                case "dog":
                    dogs.Add(animals[i]);
                    animals.Remove(animals[i]);
                    break;
            }
        }


        foreach (string animal in animals) {
            print(animal);

            switch (animal)
            {
                case "cat":
                    cats.Add(animal);
                    break;

                case "dog":
                    dogs.Add(animal);
                    break;
            }
        }
        animals.Clear();
    }
}
	

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

    string fruitName;
    float calories;
    bool collectedFruit = false;

	// Use this for initialization
	void Start () {
        calories = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void createFruit(string name, float calories)
    {
        fruitName = name;
        this.calories = calories;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.gameObject.tag == "FoodCollector")
        {
            collectedFruit = true;
            Racoon racoon = other.GetComponentInParent<Racoon>();
            racoon.AddCalories(calories);
            Debug.Log(racoon.getWeight());
            Destroy(this.gameObject);            
        }
        

    }
}

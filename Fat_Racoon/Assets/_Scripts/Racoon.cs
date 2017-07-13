using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racoon : MonoBehaviour {

    public int   health = 3;
    public float weight = 5.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float getWeight()
    {
        return weight;
    }

    public void AddCalories (float weight)
    {
        this.weight += weight;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	//This script will allow me to keep track of how many Asteroids there are


	//creates a variable for the transform component
	private Transform tf;

	// Use this for initialization
	void Start () 
	{
		tf = GetComponent<Transform>();
		GameManager.instance.asteroids.Add (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Bullet")
		{
			Destroy(this.gameObject);

			// Also destroy bullet
			Destroy(other.gameObject);
		}
	}

	void OnDestroy()
	{
		GameManager.instance.asteroids.Remove (this);
	}	
}

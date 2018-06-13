using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	public float health;
	public float moveSpeed;
	public float damage;

	// Use this for initialization
	void Start () 
	{
		GameManager.instance.asteroids.Add (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDestroy()
	{
		GameManager.instance.asteroids.Remove (this);
	}	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveEnemy : MonoBehaviour {

	
	//This script will allow me to keep track of how many active enemies there are

	// Use this for initialization
	void Start () {
		//Adds this enemy object to active enemy list
		GameManager.instance.activeEnemies.Add(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnDestroy()
	{
		//This removes this  enemy object from the active eenemy list
		GameManager.instance.activeEnemies.Remove(this);
	}
}

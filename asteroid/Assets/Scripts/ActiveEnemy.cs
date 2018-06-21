using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveEnemy : MonoBehaviour {

	//This script will allow me to keep track of how many active enemies there are

	// Use this for initialization
	void Start () {
		GameManager.instance.activeEnemies.Add(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnDestroy()
	{
		GameManager.instance.activeEnemies.Remove(this);
	}
}

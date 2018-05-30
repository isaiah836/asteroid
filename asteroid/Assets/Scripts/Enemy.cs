using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float health;
	public float moveSpeed;
	public float damage;

	// Use this for initialization
	void Start () 
	{
		GameManager.instance.enemies.Add (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDestroy()
	{
		GameManager.instance.enemies.Remove (this);
	}	
}

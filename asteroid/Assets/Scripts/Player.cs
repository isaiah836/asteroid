using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float moveSpeed;
	public float turnSpeed;
	public float health;

	// Use this for initialization
	void Start () 
	{
		GameManager.instance.player = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

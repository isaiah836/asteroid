using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_for_ship : MonoBehaviour {
	private Transform tf; // Create a variable for our transform component
	public float moveSpeed; // creates a variable that will store the movement speed from the player component
	public float turnSpeed; // creates a variable that will store the rotation speed from player component

	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform>(); // Load our transform component into our variable
	}
	
	// Update is called once per frame
	void Update () {
		// checks to see if the left or right key is pressed to rotate left or right every frame
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			tf.Rotate((Vector3.forward * turnSpeed), Space.Self);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			tf.Rotate((Vector3.back * turnSpeed), Space.Self);
		}

		// checks to see if the up or down key is pressed to move forward or back every frame 
		if (Input.GetKey(KeyCode.UpArrow))
		{
			tf.position = tf.position + (tf.rotation * (Vector3.up * moveSpeed));
		}
		if (Input.GetKey (KeyCode.DownArrow))
		{
			tf.position = tf.position + (tf.rotation * (Vector3.down * moveSpeed));
		}
		
	}
}

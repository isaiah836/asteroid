using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour {

	//Creates a variable for the transform
    private Transform tf;
	
	// Use this for initialization
	
	void Start () {
		//Grabs the component
        tf = GetComponent<Transform>();

		//This makes the enemy space ship turn towards the player once it spawns
		Vector3 LocalPosition = GameManager.instance.player.transform.position - tf.position;
		LocalPosition.Normalize();
		float angle = Mathf.Atan2(LocalPosition.y, LocalPosition.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, angle);

	}
	
	// Update is called once per frame
	void Update () {

		//This chunk of code makes the Enemy space ship follow the player by grabbing the position of the player constantly 
		Vector3 LocalPosition = GameManager.instance.player.transform.position - tf.position;
		LocalPosition.Normalize();
		float angle = Mathf.Atan2(LocalPosition.y, LocalPosition.x) * Mathf.Rad2Deg;
		Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle - 90);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, GameManager.instance.enemyRotationSpeed * Time.deltaTime);
		tf.Translate(Vector3.up * Time.deltaTime * GameManager.instance.enemyShipSpeed);
	}
}

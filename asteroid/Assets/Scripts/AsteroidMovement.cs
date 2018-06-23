using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {

	//Creates a variable for the transform
    private Transform tf;
	// Use this for initialization
	void Start () {
		//This chunk of code gets the position of the player and rotates the asteroid towards the player
        tf = GetComponent<Transform>();
		Vector3 LocalPosition = GameManager.instance.player.transform.position - tf.position;
		LocalPosition.Normalize();
		float angle = Mathf.Atan2(LocalPosition.y, LocalPosition.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, angle);

	}
	
	// Update is called once per frame
	void Update () {
		//This moves the asteroid towards the players last known position
		tf.Translate(Vector3.right * Time.deltaTime * GameManager.instance.asteroidSpeed);
	}
    
}

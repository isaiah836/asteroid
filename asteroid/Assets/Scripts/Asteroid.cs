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
		//Grabs the component
		tf = GetComponent<Transform>();
		//adds the object this script is attached to to a list of asteroids
		GameManager.instance.asteroids.Add (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		//This checks to see if it is colliding with a bullet and if it is it destroys the bullet and itself
		if (other.gameObject.tag == "Bullet")
		{
			Destroy(this.gameObject);

			// Also destroy bullet
			Destroy(other.gameObject);
		}
		// this checks to see if it is colliding with the player and if it is it sends the player to the center and takes away a life
		if (other.gameObject.tag == "player")
        {
            GameManager.instance.player.transform.position = Vector3.zero;
			foreach(ActiveEnemy item in GameManager.instance.activeEnemies)
			{
				Destroy(item.gameObject);
			}
			GameManager.instance.lives -= 1;
        }
	}

	void OnDestroy()
	{
		//if this object is destroyed then this code removess the object this script is attached to from the asteroid list
		GameManager.instance.asteroids.Remove (this);
	}	
}

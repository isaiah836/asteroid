using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShips : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//adds this object this script is attached to to enemy ships
		GameManager.instance.enemyShips.Add (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		//checks to see if the gameobject colliding is a player if it is reset it to center and wipe the board of enemies and deducts a life
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
		//When destroyed removes it from enemy ship list.
		GameManager.instance.enemyShips.Remove (this);
	}
}

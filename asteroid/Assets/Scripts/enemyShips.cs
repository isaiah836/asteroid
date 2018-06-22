using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShips : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameManager.instance.enemyShips.Add (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other)
	{
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
		GameManager.instance.enemyShips.Remove (this);
	}
}

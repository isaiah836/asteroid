using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Points : MonoBehaviour {
	public GameObject spawnAsteroid;
	public GameObject spawnEnemyShip;
	private Transform tf;
	private int ChooseSpawn;
	private int enemySize;
	private int MAXENEMYSIZE;

	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform>();
		MAXENEMYSIZE = GameManager.instance.maximumNumberActiveEnemies;
	}
	
	// Update is called once per frame
	void Update () {
		enemySize = GameManager.instance.activeEnemies.Count;
		ChooseSpawn = Random.Range(2, 2);
		if (ChooseSpawn == 1)
		{
			if (enemySize < MAXENEMYSIZE)
			{
				GameObject enemyShips = Instantiate(spawnEnemyShip, tf.position, Quaternion.identity) as GameObject;
			}
		}
		else
		{
			if (enemySize < MAXENEMYSIZE)
			{
				GameObject spawnAsteroids = Instantiate(spawnAsteroid, tf.position, Quaternion.identity) as GameObject;
			}
		}
	}
}

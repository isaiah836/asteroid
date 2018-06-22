﻿using System.Collections;
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
	}
	
	// Update is called once per frame
	void Update () {


        enemySize = GameManager.instance.activeEnemies.Count;
		ChooseSpawn = Random.Range(2, 2);
        int id = Random.Range(0, GameManager.instance.SpawnPoints.Length);
        if (enemySize < 5)
        {
            if (ChooseSpawn == 1)
            {
                GameObject enemyShips = Instantiate(spawnEnemyShip, tf.position, Quaternion.identity) as GameObject;
            }
            else if (ChooseSpawn == 2)
            {
                GameObject spawnAsteroids = Instantiate(spawnAsteroid, GameManager.instance.SpawnPoints[id].transform.position, Quaternion.identity) as GameObject;
            }
        }
		
	}
}

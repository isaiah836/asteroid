using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //Singleton
    public static GameManager instance;

    //asteroid spawnpoints
    public GameObject[] asteroidSpawnPoints;

    //Astroid prefab
    public float asteroidSpeed;

    //list of asteroids
    public List<Asteroid> asteroids;

    //Bullet spawner
    public Transform bulletSpawner;
    //Bullet prefab
    public GameObject bullet;
    public float bulletSpeed;
    public float bulletLife;

    //Enemy
    public float enemyShipSpeed;
    public float enemyRotationSpeed;

    //Enemy list
    public List<GameObject> activeEnemies;
    public bool removingEnemies;
    public int maximumNumberActiveEnemies;

    //player settings
    public GameObject player;
    public float turnSpeed;
    public float moveSpeed;
    public float score;
    public int lives;
    // Use this for initialization
    void Awake () {
		if (instance == null) 
		{
			instance = this;
			DontDestroyOnLoad (gameObject);
		} 
		else 
		{
			Destroy(gameObject);
		}
		instance = this;
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*if (lives < 0) 
		{
			DoGameOver ();
		}*/	
	}

	//TODO: Ends the game
	/*void DoGameOver()
	{
		
	}*/
}

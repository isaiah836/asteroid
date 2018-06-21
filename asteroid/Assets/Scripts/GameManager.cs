using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //Singleton
    public static GameManager instance;

    //asteroid spawnpoints
    public GameObject[] SpawnPoints;

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

    //Enemy Ships
    public float enemyShipSpeed;
    public float enemyRotationSpeed;

    //Enemy Ships list
    public List<GameObject> enemyShips;
    public bool removingEnemies;
    public int maximumNumberActiveEnemies;

	//Active enemy array
	public List<ActiveEnemy> activeEnemies;

    //player settings
    public GameObject player;
	public Transform playerPosition;
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
	void Start()
	{
		SpawnPoints = GameObject.FindGameObjectsWithTag("Spawn");
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

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
    public List<enemyShips> enemyShips;
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
	
	//Other Variables
	private int ChooseSpawn;
	private int enemySize;
	public GameObject spawnAsteroid;
	public GameObject spawnEnemyShip;
    // Use this for initialization
    void Awake () {
		//Checks to see if there is another Game Manager and if their is than delete the recently created one and if not make this the main GameManager
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
		//This add the spawn points into an array
		SpawnPoints = GameObject.FindGameObjectsWithTag("Spawn");
	}

	// Update is called once per frame
	void Update () 
	{
		//These are variable for the instantiate part of the code
		enemySize = activeEnemies.Count;
		ChooseSpawn = Random.Range(0, 3);
        int id = Random.Range(0, SpawnPoints.Length);

		//This instantiates enemy asteroids and wnwmy ships
        if (enemySize < 3)
        {
            if (ChooseSpawn == 1)
            {
                GameObject enemyShips = Instantiate(spawnEnemyShip, GameManager.instance.SpawnPoints[id].transform.position, Quaternion.identity);
            }
            else if (ChooseSpawn == 2)
            {
                GameObject spawnAsteroids = Instantiate(spawnAsteroid, GameManager.instance.SpawnPoints[id].transform.position, Quaternion.identity);
            }
        }
		// this will check if the player is out of lives and if the player is it does game over
		if (lives < 1) 
		{
			//This code wipes the screen.
			Destroy(GameManager.instance.player);
			foreach (ActiveEnemy item in activeEnemies)
			{
				Destroy(item.gameObject);
			}
			DoGameOver ();
		}
	}

	//Ends the game
	void DoGameOver()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}

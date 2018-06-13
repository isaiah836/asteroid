using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //Singleton
    public static GameManager instance;

    //asteroid spawnpoints
    public GameObject[] asteroidSpawnPoints;

    //Bullet prefab
    public GameObject bullet;
    public float bulletSpeed;
    public float bulletLife;

    //List of Asteroids
    public List<Asteroid> asteroids;
	public Player player;
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
		if (lives < 0) 
		{
			DoGameOver ();
		}	
	}

	//TODO: Ends the game
	void DoGameOver()
	{
		
	}	
}

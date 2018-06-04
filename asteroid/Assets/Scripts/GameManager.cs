using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public Movement_for_ship player;
	public List<Enemy> enemies;
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

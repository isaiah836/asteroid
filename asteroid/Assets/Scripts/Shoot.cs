using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	//This asks for a bullet prefab
	public GameObject bulletPrefab;
	//creates a variable for the transform component
	private Transform tf;

	// Use this for initialization
	void Start()
    {
		//Grabs the component
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
		//This shoots a bullet everytime the player presses the space bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
			
            Debug.Log("Shoot");
			//Spawns bullet
            GameObject bullet = Instantiate(bulletPrefab, tf.position, GameManager.instance.bulletSpawner.transform.rotation);
		}
    }
}

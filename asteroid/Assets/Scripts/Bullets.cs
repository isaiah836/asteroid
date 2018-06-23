using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {
    private Vector3 direction;
    private Transform tf;
    private float despawnTime;
    private float timer;
	// Use this for initialization
	void Start () {
        //direction = GameManager.instance.player.transform.position;
        tf = GetComponent<Transform>();
		//This assign the variable despawn time the number given by the developer in the game manager
        despawnTime = GameManager.instance.bulletLife;
    }
	
	// Update is called once per frame
	void Update ()
    {
		//This destroys the bullet after a set time by the developer
        timer += Time.deltaTime;
		Debug.Log(timer);
        if (timer > despawnTime)
        {
            Destroy(gameObject);
        }

		//This makes the bullet move
        tf.position += (transform.up * (Time.deltaTime * GameManager.instance.bulletSpeed));
    }
	void OnTriggerEnter2D(Collider2D other)
	{
		//This code makes sure that if this bullet collide into something with the tag enemy on it, it destroys that object and this object
		if (other.gameObject.tag == "Enemy")
		{
			Destroy(other.gameObject);
			++GameManager.instance.score;// adds to the player score
			Destroy(this.gameObject);
		}
	}
}

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
        despawnTime = GameManager.instance.bulletLife;
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
		Debug.Log(timer);
        if (timer > despawnTime)
        {
            Destroy(gameObject);
        }

        tf.position += (transform.up * (Time.deltaTime * GameManager.instance.bulletSpeed));
    }
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Asteroid"))
		{

		}
	}
}

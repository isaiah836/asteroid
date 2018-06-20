using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {

    public Transform tf;
    public float speed = 0.2f;

	// Use this for initialization
	void Start () {
        tf = GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void Update () {
        tf.position = Vector3.MoveTowards(tf.position,Vector3.zero, speed);
    }
    void OnCollisionEnter2D( Collision2D Player )
    {
        Destroy(Player.gameObject);
    }
}

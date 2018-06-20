using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {
    private Vector3 direction;
    private Transform tf;

	// Use this for initialization
	void Start () {
        //direction = GameManager.instance.player.transform.rotation;
        tf = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update ()
    {
       
        //transform.Translate = tf.position * direction * GameManager.instance.bulletSpeed;
    }
}

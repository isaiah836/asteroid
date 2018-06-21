using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {

	//Creates a variable for the transform
    private Transform tf;
	// Use this for initialization
	void Start () {
        tf = GetComponent<Transform>();
		Vector3 LocalPosition = GameManager.instance.player.transform.position - tf.position;
		LocalPosition.Normalize();
		float angle = Mathf.Atan2(LocalPosition.y, LocalPosition.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, angle);

	}
	
	// Update is called once per frame
	void Update () {
		tf.Translate(Vector3.right * Time.deltaTime * GameManager.instance.asteroidSpeed);
	}
    void OnCollisionEnter2D( Collision2D Player )
    {
        Destroy(Player.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public GameObject bulletPrefab;
	private Transform tf;

	// Use this for initialization
	void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
			
            Debug.Log("Shoot");
            GameObject bullet = Instantiate(bulletPrefab, tf.position, GameManager.instance.bulletSpawner.transform.rotation);
		}
    }
}

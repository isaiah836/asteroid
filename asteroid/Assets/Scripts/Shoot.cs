using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    private Transform tf;
    //private Rigidbody2D bulletSpawn;

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
            if (bulletPrefab == null)
            {
                Debug.Log("bullet prefab is null");
            }
            //if (bulletSpawn == null)
            //{
            //Debug.Log("bullet spawner is null");
            //}
            GameObject bullet = Instantiate(bulletPrefab, tf.position, Quaternion.identity);
            bullet.transform.position= bullet.transform.position + (Vector3.up * GameManager.instance.bulletSpeed);
            Debug.Log("I'm Shooting");
        }
    }
}

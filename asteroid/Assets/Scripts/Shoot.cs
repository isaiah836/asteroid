using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bullet;
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
            GameObject bullet = Instantiate(bulletPrefab, GameManager.instance.player.bulletSpawner.tranform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().AddForce(GameManager.instance.player.bulletSpwaner.position.forward * GameManager.instance.bulletSpeed);
            Debug.Log("I'm Shooting");
        }
    }
}

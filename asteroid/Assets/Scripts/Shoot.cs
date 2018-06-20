using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bullet;
    private Transform tf;
    private Rigidbody2D bullet;

    // Use this for initialization
    void Start()
    {
        tf = GetComponent<Transform>();
        bullet = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot");
            GameObject bullet = Instantiate(bulletPrefab, GameManager.instance.player.tranform.position, Quaternion.identity);
            bullet.AddForce(GameManager.instance.player.bulletSpawner.position.forward * GameManager.instance.bulletSpeed);
            Debug.Log("I'm Shooting");
        }
    }
}

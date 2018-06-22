using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerExit2D (Collider2D other)
    {
		if (other.gameObject.tag == "player")
        {
            GameManager.instance.player.transform.position = Vector3.zero;
			foreach(ActiveEnemy item in GameManager.instance.activeEnemies)
			{
				Destroy(item.gameObject);
			}
			GameManager.instance.lives -= 1;
        }
		else
		{
			Destroy(other.gameObject); // Destroys the Game Object
		}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
{
    public int damage;
    public float timeToLive;

    // Update is called once per frame
    void Update () {

        if ((timeToLive -= Time.deltaTime) > 0)
        {
            transform.Translate(Vector2.up * (speed * Time.deltaTime), Space.World);
        }
        else
        {
            Destroy(gameObject);
        }
		
	}
}

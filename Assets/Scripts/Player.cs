using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int Health = 100;
    public LayerMask collisionMask;
    public Bullet Bullet;
    public float fireRate = 0.25f;
    public float canFireIn;

    private Player_Movement PMScript;
    private GameObject player;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        PMScript = (Player_Movement)player.GetComponent(typeof(Player_Movement));
    }
	
	
	void Update () {
        canFireIn -= Time.deltaTime;

        if (canFireIn > 0)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBullet();
            canFireIn = fireRate;
        }
	}

    public void FireBullet()
    {
        if (canFireIn > 0)
        {
            return;
        }

        var direction = Vector2.up;

        var bullet = (Bullet)Instantiate(Bullet, transform.position, transform.rotation);
        bullet.Initialize(gameObject, direction, PMScript.GetVSpeed());
        
    }
}

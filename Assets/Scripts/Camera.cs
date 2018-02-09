using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    private GameObject player;
    private Player_Movement PMScript;
    private float speed;
    public Transform waypoint;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");

        PMScript = (Player_Movement) player.GetComponent(typeof(Player_Movement));

        speed = PMScript.GetVSpeed();
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position, waypoint.transform.position, speed * Time.deltaTime);

	}
}

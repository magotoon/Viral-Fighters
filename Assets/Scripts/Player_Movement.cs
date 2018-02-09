using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public float vSpeed = 2.5f;
    public float hSpeed = 4.0f;
    public Transform waypoint;
 
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        VerticalMovement();

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * (hSpeed * Time.deltaTime));
            //transform.Translate((1.5f * Time.deltaTime), 0, 0); other way to do it
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * (hSpeed * Time.deltaTime));
        }
	}

    void VerticalMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoint.transform.position, vSpeed * Time.deltaTime);
    }

    public float GetVSpeed()
    {
        return vSpeed;
    }
}

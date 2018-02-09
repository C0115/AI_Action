using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

	public int speed = 10;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = transform.right.normalized * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	public float fieldOfViewAngle = 90;
	public bool inSight;
	public float cur_health = 100;
	public float health = 100;
	public bool alive = true;



	//public GameObject[] enemy;

	// Use this for initialization
	void Start () {
		//enemy = GameObject.FindGameObjectsWithTag ("Enemy");

	}
	
	// Update is called once per frame
	void Update () {

		if (cur_health <= 0) {
			alive = false;
			cur_health = 0;
		}

	}


}
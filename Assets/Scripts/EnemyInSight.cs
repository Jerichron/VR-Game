using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInSight : MonoBehaviour {
	public PlayerHealth player;
	public Transform target;
	public float maxDistance = 4;

	// Use this for initialization
	void Start () {
		//gets the playerhealth script
		PlayerHealth playerHealth = player.GetComponent<PlayerHealth> ();

	}
	
	// Update is called once per frame
	void Update () {
		InView ();

	}

	void InView()
	{
		//gets the direction between the enemy and player
		Vector3 direction = target.position - transform.position;
		//gets the angle between the enemy and player
		float angle = Vector3.Angle (target.forward, direction);
		float distance = Vector3.Distance (target.position, transform.position);

		// if the enemy is in sight and distance set player insight
		if (Mathf.Abs (angle) > 60 && Mathf.Abs (angle) < 110 &&  distance <= maxDistance) {
			Debug.DrawLine (transform.position, target.position, Color.green);
			player.inSight = true;
		} else
			player.inSight = false;

		
	}
}

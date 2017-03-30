using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	public float fieldOfViewAngle = 35;
	public bool inSight;
	public float cur_health = 100;
	public float health = 100;
	public bool alive = true;

	private BoxCollider col;
	public GameObject[] enemy;

	// Use this for initialization
	void Start () {
		enemy = GameObject.FindGameObjectsWithTag ("Enemy");
		col = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		InView ();

		if (cur_health <= 0) {
			alive = false;
			cur_health = 0;
		}
	}

	void InView()
	{
		foreach (GameObject e in enemy) {
			Vector3 direction = e.transform.position - transform.position;
			float angle = Vector3.Angle (direction, transform.forward);
			if (angle < fieldOfViewAngle * 0.5f) {

				RaycastHit hit;

				if (Physics.Raycast (transform.position + transform.up, direction.normalized, out hit, col.size.magnitude)) {
					if (hit.collider.gameObject == e)
					{
						inSight = true;
						Debug.Log ("inSIght");
					} else
					{
						inSight = false;
						Debug.Log ("not inSight");
					}
				}
			}
		}
     }
}
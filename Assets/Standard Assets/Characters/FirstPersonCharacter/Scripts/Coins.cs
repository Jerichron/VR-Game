using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour {
	
	//GameObject player;
	public GameManager manager;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {


	}
	void OnCollisionEnter(Collision col){
		//check to see if player is hit
		if (col.gameObject.tag == "Player") {
			//Destroy the coin than add one to the score
			Destroy (this.gameObject);
			manager.score += 1;
		}

	}


}

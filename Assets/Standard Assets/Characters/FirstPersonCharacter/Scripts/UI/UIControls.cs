using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControls : MonoBehaviour {

	public bool canFire = true;
	public float cooldown = 1;
	public float setCoolown;
	bool startTime = false;
	public Image hook;
	public Image healthBar;
	public PlayerHealth playerHealth;

	public GameManager manager;
	public Text scoreText;

	void Start(){
		//GameObject player = GameObject.Find ("Player");

		//display score on start
		DisplayScore ();
	}




	
	// Update is called once per frame
	void Update () {
		//for testing
		if (Input.GetMouseButtonDown(0) && startTime == false) {
			startTime = true;
			cooldown = 0;
		}
		if (startTime) {
			if (cooldown < setCoolown) {
				cooldown += Time.deltaTime;
				CoolDown (cooldown);
				canFire = false;
			} else {
				cooldown = setCoolown;
				startTime = false;
				canFire = true;
			}
		}
		Health ();

		//Updates the score
		DisplayScore ();
	}

	void CoolDown(float time){
		hook.fillAmount = time / setCoolown;
	
	}

	void Health()
	{
		if(playerHealth.inSight && playerHealth.alive)
		{
			playerHealth.cur_health -= Time.deltaTime;
			healthBar.fillAmount = playerHealth.cur_health / playerHealth.health;
		}
	}

	void DisplayScore(){
		scoreText.text = ("Score: "+ manager.score);
	}
}
		

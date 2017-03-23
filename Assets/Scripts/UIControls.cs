using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControls : MonoBehaviour {

	float timer = 1;
	float cooldown = 1;
	bool startTime = false;
	public Image hook;


	
	// Update is called once per frame
	void Update () {
		//for testing
		if (Input.GetKeyDown (KeyCode.Space) && startTime == false) {
			startTime = true;
			cooldown = 0;
		}
		if (startTime) {
			if (cooldown < 1) {
				cooldown += Time.deltaTime;
				CoolDown (cooldown);
			} else {
				cooldown = 1;
				startTime = false;
			}
		}
	}

	void CoolDown(float time){
		hook.fillAmount = time / timer;
	}
}

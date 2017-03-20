using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControls : MonoBehaviour {

	float timer = 4;
	float cooldown = 4;
	bool startTime = false;
	public Image hook;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			startTime = true;
			cooldown = 0;
		}
		if (startTime) {
			if (cooldown < 4) {
				cooldown += Time.deltaTime;
				CoolDown (cooldown);
			} else {
				cooldown = 4;
				startTime = false;
			}

		}
	}

	void CoolDown(float time){
		hook.fillAmount = time / timer;
	}
}

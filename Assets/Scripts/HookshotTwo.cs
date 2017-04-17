﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookshotTwo : MonoBehaviour {

	public Transform Player;
	public GameObject Hook;
	public GameObject HookChild;



	// Update is called once per frame
	void Update () {
        Transform camera = Camera.main.transform;
        Ray HookRay = new Ray(camera.position, camera.rotation * Vector3.forward);
		Debug.DrawRay (HookRay.origin, HookRay.direction, Color.green);
		RaycastHit HookHit;

		if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire3"))
		{
			HookChild = null;
			if (Physics.Raycast(HookRay, out HookHit))
			{
				Debug.DrawRay (HookRay.origin, HookRay.direction, Color.red);
				HookChild = Instantiate(Hook, HookHit.point, Quaternion.identity) as GameObject;
					Player.localPosition = HookHit.point;
					Debug.Log ("Hook Hit");
					}
}
		if (Input.GetMouseButtonUp(0) || Input.GetButtonUp("Fire3"))
					{
						if (HookChild != null)
							Destroy(HookChild);
					}}}

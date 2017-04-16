using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hookshot : MonoBehaviour {

	public Transform Player;
	public GameObject Hook;
	public GameObject HookChild;
	private PauseMenu freeze;
	private UIControls activeHook;

	void Start(){
		freeze = FindObjectOfType<PauseMenu> ();
		activeHook = FindObjectOfType<UIControls> ();
	}


	// Update is called once per frame
	void Update () {
		Ray HookRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		Debug.DrawRay (HookRay.origin, HookRay.direction, Color.green);
		RaycastHit HookHit;

		if (Input.GetMouseButtonDown(0)  && freeze.pauseGame == false  && activeHook.canFire == true|| Input.GetButtonDown("Fire3") && freeze.pauseGame == false && activeHook.canFire == true)
		{
			HookChild = null;
			if (Physics.Raycast(HookRay, out HookHit, Mathf.Infinity, LayerMask.NameToLayer("UI")))
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
					}
	}
}

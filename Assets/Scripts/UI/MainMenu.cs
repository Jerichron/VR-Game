using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour {
	public EventSystem es;
	private GameObject stored;

	void Start(){
		stored = es.firstSelectedGameObject;
	}

	void Update(){
		if(es.currentSelectedGameObject!=stored){
			if (es.currentSelectedGameObject == null) {
			
				es.SetSelectedGameObject (stored);
			} else {
				stored = es.currentSelectedGameObject;
			}
		}
	}


	public void PlayGame(){
		Application.LoadLevel (1);
}

	public void ExitGame(){

		Application.Quit ();
	}
}

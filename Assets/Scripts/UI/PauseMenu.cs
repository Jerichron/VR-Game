using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour {
	public bool pauseGame = false;
	private bool showUI = false;
	public Canvas gameUI;
	public Canvas pauseUI;
	public GameObject crossfire;
	public EventSystem check;
	private GameObject stored;

	void Start(){
		stored = check.firstSelectedGameObject;
	}
		

	void Update(){

		if(check.currentSelectedGameObject!=stored){
			if(check.currentSelectedGameObject == null){

			check.SetSelectedGameObject (stored);
			} else {
			stored = check.currentSelectedGameObject;
			}
		}



		if (Input.GetKeyDown (KeyCode.Joystick1Button7) || Input.GetKeyDown (KeyCode.Escape)) {
			if (!pauseGame) {
				pauseGame = true;
				check.enabled = true;
			} else {
				pauseGame = false;
				check.enabled = false;
			}
		}
		if (pauseGame == true) {
			Time.timeScale = 0;
			gameUI.enabled = false;
			pauseUI.enabled = true;

		} else {
			Time.timeScale = 1;
			gameUI.enabled = true;
			pauseUI.enabled = false;
		}

	}

	public void Resume(){
		pauseGame = false;
	}

	public void Menu(){
		Application.LoadLevel (0);
	}

}

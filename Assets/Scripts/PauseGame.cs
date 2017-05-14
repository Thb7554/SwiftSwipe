using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

	public bool paused = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (paused) {
			Time.timeScale = 0;
		} else
			Time.timeScale = 1;
	}

	public void pauseGame(){
		if (!paused) {		
			paused = true;
		} else
			paused = false;
	}
}

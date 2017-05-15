using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour {

	private Button nextBUtton;
	private Button replayButton;
	private Button quitButton;
	public Text timerText;

	void Start () {
		timerText.text = 0.225 + " sec.";
	}

	void displayResult(){
		timerText.text = 0.225 + " sec.";
	}

	public void SetLevel(int level){
		if (level != null) { 
			SceneManager.LoadScene ("Scene" + level);
		}
	}

	public void quitLevel(){
		SceneManager.LoadScene ("StartMenu");
		//OnNextWindow();
	}
}

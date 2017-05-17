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
    public int currentLevel;

	void Start () {
        currentLevel = PlayerPrefs.GetInt("CurrentLevel");

        if (PlayerPrefs.GetFloat("Level" + currentLevel + "Low") > PlayerPrefs.GetFloat("Level" + currentLevel + "Time"))
        {
            timerText.text = PlayerPrefs.GetFloat("Level" + currentLevel + "Low") + " sec.";
        }
        else
        {
            timerText.text = "NEW HIGHSCORE!!!";
        }
        timerText.text += "\n Highscore " + PlayerPrefs.GetFloat("Level" + currentLevel + "Time") + " sec.";
    }

	void displayResult(){
        if(PlayerPrefs.GetFloat("Level" + currentLevel + "Low") > PlayerPrefs.GetFloat("Level" + currentLevel + "Time"))
        {
            timerText.text = PlayerPrefs.GetFloat("Level" + currentLevel + "Low") + " sec.";
        }
        else
        {
            timerText.text = "NEW HIGHSCORE!!!";
        }
        timerText.text += "\n Highscore " + PlayerPrefs.GetFloat("Level" + currentLevel + "Time") + " sec.";
    }

    public void ResetLevel() {
        SceneManager.LoadScene("Scene" + currentLevel);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    private float gTimer;
	public float gTimerMS = 0; //Milliseconds of timer
	public int gTimerSec = 0; //Seconds of timer
	public Text timerText;
    public bool boolOn;
    public bool finished;
    public int currentLevel;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(boolOn){
            gTimerMS += Time.deltaTime;

            /*if (gTimerMS > 999) {
                gTimerMS = 0;
                gTimerSec++;
            }
    */
            //timerText.text = gTimerSec + "\"" + gTimerMS;
            
            
           // timerText.text = gTimerMS.ToString("f3");
            // = gTimerSec + "\"" + gTimerMS;
        }
        else
        {
            if(!finished)
                gTimerMS = 0;
        }
		if (!finished) {
			timerText.text = "TIME: " + gTimerMS.ToString ("f3");
		} else {
            Debug.Log("Finish " + gTimerMS.ToString("f3"));
            float time = gTimerMS;
            float topScore = PlayerPrefs.GetFloat("Level" + currentLevel + "Time");
            if (time < topScore || topScore == 0)
            {
                PlayerPrefs.SetFloat("Level" + currentLevel + "Time", time);
            }
            else
            {
                PlayerPrefs.SetFloat("Level" + currentLevel + "Low", time);
            }

            PlayerPrefs.SetInt("OpenLevelSelect", 1);
            PlayerPrefs.SetInt("CurrentLevel", currentLevel);
            //SceneManager.LoadScene("StartMenu");
            finished = false;
            SceneManager.LoadScene("LevelFinish");
        }

		

	}

}

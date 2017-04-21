using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
<<<<<<< HEAD
    private float gTimer;
=======

	public float gTimerMS = 0; //Milliseconds of timer
	public int gTimerSec = 0; //Seconds of timer
	public Text timerText;
>>>>>>> origin/Branch_Sun
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gTimerMS += Time.deltaTime;

        /*if (gTimerMS > 999) {
			gTimerMS = 0;
			gTimerSec++;
		}
*/
        //timerText.text = gTimerSec + "\"" + gTimerMS;

        timerText.text = gTimerMS.ToString("f3");

		// = gTimerSec + "\"" + gTimerMS;

	}
}

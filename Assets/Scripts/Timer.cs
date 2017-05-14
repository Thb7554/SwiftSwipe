using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    private float gTimer;
	public float gTimerMS = 0; //Milliseconds of timer
	public int gTimerSec = 0; //Seconds of timer
	public Text timerText;
    public bool boolOn;
    public bool finished;
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
            
            
            timerText.text = gTimerMS.ToString("f3");
            // = gTimerSec + "\"" + gTimerMS;
        }
        else
        {
            gTimerMS = 0;
        }
        if(!finished){
            timerText.text = "TIME: " + gTimerMS.ToString("f3");
        }

		

	}
}

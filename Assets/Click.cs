using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour {
    public GameObject indict;
    public Camera cam;
    public bool startedBool;
    public bool endedBool;
    public float score;
    private bool scoring;
    public Text scoreText;
    // Use this for initialization
    void Start () {
        startedBool = false;
        endedBool = false;
        score = 0;
        scoring = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
        {
            Vector3 screenCor = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, 0));
            Instantiate(indict, new Vector3(screenCor.x, screenCor.y,0), new Quaternion());
            this.GetComponent<Timer>().boolOn = true;
        }
        else{
            this.GetComponent<Timer>().boolOn = false;
            this.GetComponent<Timer>().finished = false;
            if (startedBool && endedBool)
            {
                startedBool = false;
                endedBool = false;
                this.GetComponent<Timer>().finished = true;
            }
            foreach (GameObject trail in GameObject.FindGameObjectsWithTag("Trail"))
            {
                //Destory nodes
                trail.GetComponent<DestroyThis>().destroyBool = true;     
            }
        }
	}
}

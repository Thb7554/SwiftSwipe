using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour {
    public GameObject indict;
    public GameObject cursor;
    public Camera cam;
    public bool startedBool;
    public bool endedBool;
    public float score;
    private bool scoring;
    public Text scoreText;
    public bool outOfBounds;
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
            outOfBounds = false;
            this.GetComponent<Timer>().finished = false;
            Vector3 screenCor = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, 0));
            Instantiate(indict, new Vector3(screenCor.x, screenCor.y,0), new Quaternion());
            cursor.transform.position = screenCor + new Vector3(0,0,10);
            this.GetComponent<Timer>().boolOn = true;
        }
        else{
            cursor.GetComponent<TrailRenderer>().Clear();
            this.GetComponent<Timer>().boolOn = false;
            foreach (GameObject trail in GameObject.FindGameObjectsWithTag("Trail"))
            {
                if(!outOfBounds && trail.GetComponent<DestroyThis>().missBool){
                    outOfBounds = true;
                }
                //Destroy nodes
                trail.GetComponent<DestroyThis>().destroyBool = true;     
            }
            if (!outOfBounds && startedBool && endedBool)
            {
                this.GetComponent<Timer>().finished = true;
            }
            startedBool = false;
            endedBool = false;
            
        }
        
        //Mobile
        /*
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            outOfBounds = false;
            this.GetComponent<Timer>().finished = false;
            Vector3 screenCor = cam.ScreenToWorldPoint(new Vector3(touch.position.x,touch.position.y, 0));
            Instantiate(indict, new Vector3(screenCor.x, screenCor.y,0), new Quaternion());
            cursor.transform.position = screenCor + new Vector3(0,0,10);
            this.GetComponent<Timer>().boolOn = true;
        }
        else{
            cursor.GetComponent<TrailRenderer>().Clear();
            this.GetComponent<Timer>().boolOn = false;
            foreach (GameObject trail in GameObject.FindGameObjectsWithTag("Trail"))
            {
                if(!outOfBounds && trail.GetComponent<DestroyThis>().missBool){
                    outOfBounds = true;
                }
                //Destroy nodes
                trail.GetComponent<DestroyThis>().destroyBool = true;     
            }
            if (!outOfBounds && startedBool && endedBool)
            {
                this.GetComponent<Timer>().finished = true;
            }
            startedBool = false;
            endedBool = false;
            
        }
        */
	}
}

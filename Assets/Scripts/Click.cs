using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public GameObject indict;
    public GameObject cursor;
    public Camera cam;
    public bool startedBool;
    public bool endedBool;
    public float score;
    private bool scoring;
    public bool outOfBounds;
    // Use this for initialization
    void Start()
    {
        startedBool = false;
        endedBool = false;
        score = 0;
        scoring = false;
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if(Input.GetMouseButton(0))
		{
			this.GetComponent<Timer>().finished = false;
			Vector3 screenCor = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, 0));
			Instantiate(indict, new Vector3(screenCor.x, screenCor.y,0), new Quaternion());
            if (!outOfBounds)
            {
                cursor.transform.position = screenCor + new Vector3(0, 0, 10);
            }
            else
            {
                cursor.GetComponent<TrailRenderer>().material.color = Color.red;
                this.GetComponent<Timer>().boolOn = false;
            }


            if (!outOfBounds && startedBool && endedBool) //If all are triggered, you were on the path
            {
                this.GetComponent<Timer>().finished = true;
                this.GetComponent<Timer>().boolOn = false;
            }
        }
		else{
            cursor.GetComponent<TrailRenderer>().material.color = Color.white;
            cursor.GetComponent<TrailRenderer>().Clear();
			this.GetComponent<Timer>().boolOn = false;
			startedBool = false;
			endedBool = false;
            outOfBounds = false;
        }
#endif

#if UNITY_ANDROID
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            this.GetComponent<Timer>().finished = false;
            Vector3 screenCor = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, 0));
            Instantiate(indict, new Vector3(screenCor.x, screenCor.y,0), new Quaternion());
            if (!outOfBounds)
            {
                cursor.transform.position = screenCor + new Vector3(0, 0, 10);
            }
            else
            {
                cursor.GetComponent<TrailRenderer>().material.color = Color.red;
                this.GetComponent<Timer>().boolOn = false;
            }


            if (!outOfBounds && startedBool && endedBool) //If all are triggered, you were on the path
            {
                this.GetComponent<Timer>().finished = true;
                this.GetComponent<Timer>().boolOn = false;
            }
        }
         else{
            cursor.GetComponent<TrailRenderer>().material.color = Color.white;
            cursor.GetComponent<TrailRenderer>().Clear();
			this.GetComponent<Timer>().boolOn = false;
			startedBool = false;
			endedBool = false;
            outOfBounds = false;
         }
#endif

    }
}
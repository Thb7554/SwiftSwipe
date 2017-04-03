using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {
    public GameObject indict;
    public Camera cam;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
        {
            Vector3 screenCor = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, 0));
            Instantiate(indict, new Vector3(screenCor.x, screenCor.y,0), new Quaternion());
        }
	}
}

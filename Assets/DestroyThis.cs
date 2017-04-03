using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThis : MonoBehaviour {
    public float Timer;
	// Use this for initialization
	void Start () {
		if (Physics.Raycast(transform.position, transform.forward * -1, 10))
            print("There is something in front of the object!");
        else
            print("Nothing!");
	}
	
	// Update is called once per frame
	void Update () {
		Timer-= Time.deltaTime;
        if(Timer < 0){
            Destroy(this.gameObject);
        }
	}
}

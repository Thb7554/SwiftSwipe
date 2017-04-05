using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float gTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		gTimer += Time.deltaTime;
	}
}

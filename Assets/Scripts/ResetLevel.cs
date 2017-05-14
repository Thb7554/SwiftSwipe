using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour {

	string sceneName;

	// Use this for initialization
	void Start () {
		sceneName = SceneManager.GetActiveScene ().name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Reset(){
		SceneManager.LoadScene(sceneName);
	}
}

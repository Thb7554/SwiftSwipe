using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public int levelNum;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("OpenLevelSelect", 0);
    }

    public void GoToLevelSelect()
    {
        PlayerPrefs.SetInt("OpenLevelSelect", 1);
        SceneManager.LoadScene("StartMenu");
    }
}

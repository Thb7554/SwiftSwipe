using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;


public class GameLoop : MonoBehaviour
{
	private int value; //Checks the current state
	private bool gameOver = false;
	GameManager gm;
	//private int levelNum = gm.GetComponent<GameManager>.levelNum();

	// Use this for initialization
	void Start()
	{


	}

	// Update is called once per frame
	void Update()
	{

	}

	bool LoadSceneOkay()
	{ //To be finished method

		return false;
	}

	public void LoadState(int load)
	{

		switch (load)
		{
		case 0:
			gameOver = false;
			SceneManager.LoadScene("Title"); //Opens start screen
			break;


		case 1:
			gameOver = false;
			SceneManager.LoadScene("Menu"); //Loads level (Change name of level as needed)
			break;

		case 2:
			//SceneManager.LoadScene("Scene" + levelNum); //Will be altered and prepped to work with the Menu Screen level select
			SceneManager.LoadScene("Scene1");//loads level screen
			break;

	/*	case 3:
			SceneManager.LoadScene("LevelClear",LoadScene.Additive); //Loads level (Change name of level as needed)
			break;
*/
		case 4:

			Application.Quit(); //Loads level (Change name of level as needed)
			break;

		}
	}
}

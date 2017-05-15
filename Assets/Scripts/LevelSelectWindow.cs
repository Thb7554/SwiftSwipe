using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectWindow : GenericWindow {

    public Text text1, text2, text3, text4;

    public void ChooseLevel(int level)
    {
        Debug.Log("Choose level: " + level);
        SceneManager.LoadScene("Scene" + level);
    }

    public void GoBack()
    {
        OnPreviousWindow();
    }

    public override void Open()
    {
    
        text1.text = PlayerPrefs.GetFloat("Level1Time").ToString("f3");
        text2.text = PlayerPrefs.GetFloat("Level2Time").ToString("f3");
        text3.text = PlayerPrefs.GetFloat("Level3Time").ToString("f3");
        text4.text = PlayerPrefs.GetFloat("Level4Time").ToString("f3");
                                                        

        base.Open();
    }
}

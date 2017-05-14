using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectWindow : GenericWindow {

    public void ChooseLevel(int level)
    {
        Debug.Log("Choose level: " + level);
        SceneManager.LoadScene("Scene" + level);
    }

    public void GoBack()
    {
        OnPreviousWindow();
    }
}

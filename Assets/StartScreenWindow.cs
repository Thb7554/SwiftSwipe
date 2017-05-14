using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScreenWindow : GenericWindow {

    [SerializeField]
    private Button startButton;

    public override void Open()
    {
        firstSelected = startButton.gameObject;
        base.Open();
    }

    public void Begin()
    {
        OnNextWindow();
    }


}

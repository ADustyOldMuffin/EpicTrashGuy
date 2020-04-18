using System;
using System.Collections;
using System.Collections.Generic;
using Constants;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public SceneController sceneController;

    public void OnStartButtonClick()
    {
        sceneController.ChangeScene(Scenes.StreetBattle);
    }

    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}

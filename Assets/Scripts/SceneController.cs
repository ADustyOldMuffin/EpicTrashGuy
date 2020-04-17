using System;
using System.Collections;
using System.Collections.Generic;
using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadScene(Scenes.Testing.GetSceneName(), LoadSceneMode.Single);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1.0f;
    private static readonly int Start = Animator.StringToHash("Start");

    public void ChangeScene(Scenes scene)
    {
        StartCoroutine(LoadLevel(scene));
    }

    private IEnumerator LoadLevel(Scenes scene)
    {
        transition.SetTrigger(Start);
        
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene.GetSceneName(), LoadSceneMode.Single);
    }
}

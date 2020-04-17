using System.Collections;
using System.Collections.Generic;
using Constants;
using UnityEngine;

public class DevPreload : MonoBehaviour
{
    private void Awake()
    {
        GameObject check = GameObject.Find("__app");

        if (check == null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(Scenes.Preload.GetSceneName());
        }
        
        Destroy(gameObject);
    }
}

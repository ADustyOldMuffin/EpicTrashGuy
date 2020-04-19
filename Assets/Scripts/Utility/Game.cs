using System;
using System.Collections;
using System.Collections.Generic;
using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameState state;

    public InputMaster input;

    private PlayerCleanliness health;
    
    private void Awake()
    {
        input = new InputMaster();
        state = GameState.Menu;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    public void StartGame()
    {
        FindObjectOfType<SceneController>().ChangeScene(Scenes.StreetBattle);
    }

    public void EndGame(bool hasWon)
    {
        health = null;

        FindObjectOfType<SceneController>().ChangeScene(hasWon ? Scenes.Won : Scenes.Lost);
    }

    public void SetHealth(PlayerCleanliness gameHealth)
    {
        health = gameHealth;
    }

    private void LateUpdate()
    {
        if (health == null)
            return;

        if (health.currentCleanliness <= 0)
        {
            EndGame(false);
        } 
        else if (health.currentCleanliness > 0 && GameObject.FindObjectsOfType<Imp>().Length == 0)
        {
            EndGame(true);
        }
    }
}

public enum GameState
{
    Play,
    Menu
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameState state;

    public InputMaster input;
    
    private void Awake()
    {
        input = new InputMaster();
        state = GameState.Play;
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }
}

public enum GameState
{
    Play,
    Pause
}
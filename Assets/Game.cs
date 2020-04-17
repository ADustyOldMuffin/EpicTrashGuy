using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameState state;

    private void Awake()
    {
        state = GameState.Play;
    }
}

public enum GameState
{
    Play,
    Pause
}
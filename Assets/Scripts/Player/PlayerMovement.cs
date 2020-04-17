using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private float _upDown;
    private float _sideways;

    private Vector3 _newPosition;

    private Game _game;
    
    private void Awake()
    {
        _game = FindObjectOfType<Game>();

        _game.input.Movement.UpAndDown.performed += ctx => _upDown = ctx.ReadValue<float>();
        _game.input.Movement.Sideways.performed += ctx => _sideways = ctx.ReadValue<float>();
    }

    private void Start()
    {
        _newPosition = transform.position;
    }

    private void OnEnable()
    {
        _game.input.Movement.Enable();
    }

    private void OnDisable()
    {
        _game.input.Movement.Disable();
    }

    private void FixedUpdate()
    {
        _newPosition += ((transform.up * _upDown) + (transform.right * _sideways)) * moveSpeed;

        transform.position = _newPosition * Time.fixedDeltaTime;
    }
}

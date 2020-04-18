using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRighedbodyMovement : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField] private float speed = 5;
    private Vector2 _playersInput;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        _playersInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        _rb.velocity = _playersInput * (speed);
    }
}

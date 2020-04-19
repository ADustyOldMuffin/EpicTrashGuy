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

    private Rigidbody2D _myRigidbody;
    private SpriteRenderer _spriteRenderer;

    [SerializeField] private Animator playerAnimator;
    
    private void Awake()
    {
        _game = FindObjectOfType<Game>();

        _game.input.Movement.UpAndDown.performed += ctx => _upDown = ctx.ReadValue<float>();
        _game.input.Movement.Sideways.performed += ctx => _sideways = ctx.ReadValue<float>();

        _myRigidbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
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
        var myTransform = transform;

        _newPosition = new Vector3(_sideways, _upDown);
        
        ChangeMovementSprite(_newPosition);
        MoveCharacter(_newPosition);
    }

    private void MoveCharacter(Vector3 change)
    {
        _myRigidbody.MovePosition(transform.position + (change * (moveSpeed * Time.fixedDeltaTime)));
    }

    private void ChangeMovementSprite(Vector3 movement)
    {
        if (movement.y > 0)
        {
            playerAnimator.Play("PlayerRunUp");
        } else if (movement.y < 0)
        {
            playerAnimator.Play("PlayerRunDown");
        } 
        else if (movement.x < 0 || movement.x > 0)
        {
            playerAnimator.Play("PlayerRunSideways");
        } 
        else if (movement.x.Equals(0.0f) && movement.y.Equals(0.0f))
        {
            playerAnimator.Play("PlayerIdle");
        }

        if (movement.x > 0 && !_spriteRenderer.flipX)
        {
            _spriteRenderer.flipX = true;
        }
        else if (movement.x <= 0 && _spriteRenderer.flipX)
        {
            _spriteRenderer.flipX = false;
        }
    }
}

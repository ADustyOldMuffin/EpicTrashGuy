using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject upAttack;
    [SerializeField] private GameObject downAttack;
    [SerializeField] private GameObject rightAttack;
    [SerializeField] private GameObject leftAttack;
    [SerializeField] private GameObject firePoint;
    [SerializeField] private Rigidbody2D rangedRigidBody;

    public float meleeCooldown;

    private float _currentMeleeCooldown = 0;
    [SerializeField] private float bulletForce;
    private Vector2 mousePos;
    [SerializeField] private GameObject rangedFireballObject;
    private Game _game;
    [SerializeField] private Animator animator;
    private Rigidbody2D myRigidBody;

    private void Awake()
    {
        _game = FindObjectOfType<Game>();
        _game.input.Attack.MeleeAttack.performed += ctx => StartCoroutine(OnMeleeAttack(ctx));
        _game.input.Attack.RangedAttack.performed += OnRangedAttack;
        myRigidBody = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rangedRigidBody.gameObject.transform.position = transform.position;
    }

    private void FixedUpdate()
    {
        if (_currentMeleeCooldown > 0)
            _currentMeleeCooldown -= Time.fixedDeltaTime;

        var lookDir = mousePos - myRigidBody.position;
        float angle = math.atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rangedRigidBody.rotation = angle;
    }

    private void OnEnable()
    {
        _game.input.Attack.Enable();
    }

    private void OnDisable()
    {
        _game.input.Attack.Disable();
    }

    private IEnumerator OnMeleeAttack(InputAction.CallbackContext context)
    {
        if (_currentMeleeCooldown > 0)
             yield break;
        
        var playerPosition = transform.position;
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        animator.Play("PlayerAttack");

        // We're not on top or bottom position so we're right or left
        if (mousePosition.y < playerPosition.y + 10 && mousePosition.y > playerPosition.y - 10)
        {
            // Right
            if (mousePosition.x > playerPosition.x)
            {
                rightAttack.SetActive(true);
                yield return new WaitForSeconds(.25f);
                rightAttack.SetActive(false);
            }
            // Left
            else
            {
                leftAttack.SetActive(true);
                yield return new WaitForSeconds(.25f);
                leftAttack.SetActive(false);
            }
        }
        else // We're top or bottom
        {
            // Top
            if (mousePosition.y > playerPosition.y)
            {
                upAttack.SetActive(true);
                yield return new WaitForSeconds(.25f);
                upAttack.SetActive(false);
            }
            // Bottom
            else 
            {
                downAttack.SetActive(true);
                yield return new WaitForSeconds(.25f);
                downAttack.SetActive(false);
            }
        }

        _currentMeleeCooldown = meleeCooldown;
    }

    private void OnRangedAttack(InputAction.CallbackContext context)
    {
        var go = Instantiate(rangedFireballObject, firePoint.transform.position, firePoint.transform.rotation);
        var goRb = go.GetComponent<Rigidbody2D>();
        goRb.AddForce(firePoint.transform.up * bulletForce, ForceMode2D.Impulse);
    }
}

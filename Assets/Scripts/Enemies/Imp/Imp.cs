using System;
using System.Collections;
using System.Collections.Generic;
using Constants;
using Unity.Mathematics;
using UnityEngine;

public class Imp : MonoBehaviour
{
    public EnemyState state;
    
    public GameObject player;
    public GameObject rangedAttackProjectile;
    public GameObject firePoint;
    
    public float rangedAttackDistance;
    public float meleeAttackDistance;
    public float chaseDistance;
    public float noticeDistance;
    public float moveSpeed;
    public float rangedCoolDown;
    public float meleeCoolDown;
    
    public Vector3 moveToPosition;

    private bool _noticedPlayer = false;

    private float currentRangeCoolDown = 0;
    private float currentMeleeCoolDown = 0;
    

    private void Awake()
    {
        if (player != null)
            return;
        
        player = GameObject.FindWithTag("Player");

        moveToPosition = transform.position;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (player == null)
            return;
        
        var angle = math.atan2(player.transform.position.y, player.transform.position.x) * Mathf.Rad2Deg - 90f;
        firePoint.GetComponent<Rigidbody2D>().rotation = angle;

        var distanceToPlayer = Vector2.Distance(player.transform.position, transform.position);

        state = DetermineState(distanceToPlayer);

        moveToPosition = DetermineMoveToPosition();

        if (moveToPosition != transform.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, moveToPosition, moveSpeed * Time.deltaTime);
        }

        if (state == EnemyState.RangeAttack && currentRangeCoolDown <= 0)
        {
            var projectile = Instantiate(rangedAttackProjectile, firePoint.transform.position, firePoint.transform.rotation);
            var goRb = projectile.GetComponent<Rigidbody2D>();
            goRb.AddForce(goRb.transform.up * .01f, ForceMode2D.Impulse);

            currentRangeCoolDown = rangedCoolDown;
        }

        if (currentRangeCoolDown > 0)
            currentRangeCoolDown -= Time.fixedDeltaTime;
    }

    private EnemyState DetermineState(float distanceToPlayer)
    {
        var state = EnemyState.Idle;
        
        // We haven't noticed the player and they're to far away.
        if (distanceToPlayer > noticeDistance && !_noticedPlayer)
        {
            state = EnemyState.Idle;
        }
        // We've noticed the player so we're going to chase them
        else if (distanceToPlayer > noticeDistance && _noticedPlayer)
        {
            state = EnemyState.MoveToRangedAttackRange;
        }
        // We're closer than notice range
        else
        {
            _noticedPlayer = true;
            // If we're not in range to attack
            if (distanceToPlayer > rangedAttackDistance)
            {
                state = EnemyState.MoveToRangedAttackRange;
            }
            // We're close enough to attack
            else
            {
                state = EnemyState.RangeAttack;

                if (distanceToPlayer < chaseDistance && distanceToPlayer > meleeAttackDistance)
                {
                    state = EnemyState.MoveToMelee;
                }
                else if (distanceToPlayer <= meleeAttackDistance)
                {
                    state = EnemyState.MeleeAttack;
                }
            }
        }

        return state;
    }

    private Vector3 DetermineMoveToPosition()
    {
        var position = transform.position;
        
        switch (state)
        {
            case EnemyState.MoveToRangedAttackRange:
                position = player.transform.position;
                break;
            
            case EnemyState.MoveToMelee:
                position = player.transform.position;
                break;
            
            case EnemyState.MeleeAttack:
                position = transform.position;
                break;
            
            case EnemyState.RangeAttack:
                position = transform.position;
                break;
        }

        return position;
    }
}

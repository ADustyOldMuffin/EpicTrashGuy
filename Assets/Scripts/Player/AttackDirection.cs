using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayersAttackStat
{
    melee,
    range
}

public class AttackDirection : MonoBehaviour
{


    private PlayersAttackStat _playersAttackStat;

    
    [SerializeField]  private Vector2 _direction;
    private Vector3 _mousePos;

    private Camera _cam;

    [Header("Attacks")] 
    [SerializeField] private ShowPlayersAttackState showPlayersAttackState;
    [SerializeField] private GameObject rangeAttack; 
    [SerializeField] private GameObject meleeAttack;
    [SerializeField] private float _degree = 0;
    [SerializeField] private float leftRightDistanceToPlayer = 3.7f, upDownDistanceToPLayer = 4.5f;
    [SerializeField] private float attackTime = .1f;
    
    
    
    void Awake()
    {
        _cam = Camera.main;
    }

    private void Start()
    {
        _playersAttackStat = PlayersAttackStat.melee;
        showPlayersAttackState.ChangeStateSprite(_playersAttackStat);
    }

    void Update()
    {
        _mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        _direction = _mousePos - transform.position;
        _direction = _direction.normalized;
        
        //Change attack state
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (_playersAttackStat == PlayersAttackStat.melee)
            {
                _playersAttackStat = PlayersAttackStat.range;
                showPlayersAttackState.ChangeStateSprite(_playersAttackStat);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (_playersAttackStat == PlayersAttackStat.range)
            {
                _playersAttackStat = PlayersAttackStat.melee;
                showPlayersAttackState.ChangeStateSprite(_playersAttackStat);
            }
        }

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            switch (_playersAttackStat)
            {
                case (PlayersAttackStat.melee):
                    _degree = Mathf.Asin(_direction.y) * Mathf.Rad2Deg;
                    
                    if (_degree > 45) //Up
                    {
                        meleeAttack.transform.position = transform.position + new Vector3(0, upDownDistanceToPLayer, 0);
                        meleeAttack.transform.localScale = new Vector3(6.5f, 4, 1);
                        StartCoroutine(HitBoxAttack());
                    }
                    else if (_degree < -45) //Down
                    {
                        meleeAttack.transform.position = transform.position + new Vector3(0, -upDownDistanceToPLayer, 0);
                        meleeAttack.transform.localScale = new Vector3(6.5f, 4, 1);
                        StartCoroutine(HitBoxAttack());
                    }
                    else if (_degree > -45 && _degree < 45)
                    {
                        if (_direction.x < 0) //Left
                        {
                            meleeAttack.transform.position = transform.position + new Vector3(-leftRightDistanceToPlayer, 0, 0);
                            meleeAttack.transform.localScale = new Vector3(4, 6.5f, 1);
                            StartCoroutine(HitBoxAttack());
                        }
                        else //Right
                        {
                            meleeAttack.transform.position = transform.position + new Vector3(leftRightDistanceToPlayer, 0, 0);
                            meleeAttack.transform.localScale = new Vector3(4, 6.5f, 1);
                            StartCoroutine(HitBoxAttack());
                        }
                    }
                    
                    
                    break;
                case (PlayersAttackStat.range):
                    if (_direction.x < 0)
                    {
                        _degree = 90 - Mathf.Asin(_direction.y) * Mathf.Rad2Deg;
                    }
                    else
                    {
                        _degree = Mathf.Asin(_direction.y) * Mathf.Rad2Deg + 270;
                    }
                    
                    Quaternion _quaternionDir = Quaternion.Euler(0, 0, _degree);
                    Instantiate(rangeAttack, transform.position, _quaternionDir);
                    break;
            }
        }
    }

    IEnumerator HitBoxAttack()
    {
        meleeAttack.SetActive(true);
        yield return new WaitForSeconds(attackTime);
        meleeAttack.SetActive(false);
    }
}

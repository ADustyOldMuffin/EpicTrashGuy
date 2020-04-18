using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDirection : MonoBehaviour
{
    private enum PlayersAttackStat
    {
        melee,
        range
    }

    private PlayersAttackStat _playersAttackStat;

    
    [SerializeField]  private Vector2 _direction;
    private Vector3 _mousePos;

    private Camera _cam;
    
    [Header("Attacks")] [SerializeField]
    private GameObject rangeAttack;

    public float _degree = 0;
    public float test;
    
    void Awake()
    {
        _cam = Camera.main;
    }

    private void Start()
    {
        _playersAttackStat = PlayersAttackStat.range;
    }

    void Update()
    {
        _mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        _direction = _mousePos - transform.position;
        _direction = _direction.normalized;

        if (_direction.x < 0)
        {
            _degree = 90 - Mathf.Asin(_direction.y) * Mathf.Rad2Deg;
        }
        else
        {
            _degree = Mathf.Asin(_direction.y) * Mathf.Rad2Deg + 270;
        }
        
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            switch (_playersAttackStat)
            {
                case (PlayersAttackStat.melee):
                
                    break;
                case (PlayersAttackStat.range):
                    Quaternion _quaternionDir = Quaternion.Euler(0, 0, _degree);
                    Instantiate(rangeAttack, transform.position, _quaternionDir);
                    break;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, 1f);
        Gizmos.color = Color.magenta;
        //Gizmos.DrawLine(transform.position, transform.position + (Vector3)_direction);
    }
}

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
    
    [Header("Attacks")] 
    [SerializeField] private GameObject rangeAttack, meleeAttack;

    [SerializeField] private float _degree = 0;
     
    
    
    
    void Awake()
    {
        _cam = Camera.main;
    }

    private void Start()
    {
        _playersAttackStat = PlayersAttackStat.melee;
    }

    void Update()
    {
        _mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        _direction = _mousePos - transform.position;
        _direction = _direction.normalized;


        
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            switch (_playersAttackStat)
            {
                case (PlayersAttackStat.melee):
                    _degree = Mathf.Asin(_direction.y) * Mathf.Rad2Deg;
                    
                    if (_degree > 45) //Up
                    {
                        meleeAttack.transform.position = transform.position + new Vector3(0, 3, 0);
                    }
                    else if (_degree < -45) //Down
                    {
                        meleeAttack.transform.position = transform.position + new Vector3(0, -3, 0);
                    }
                    else if (_degree > -45 && _degree < 45)
                    {
                        if (_direction.x < 0) //Left
                        {
                            meleeAttack.transform.position = transform.position + new Vector3(-3, 0, 0);
                        }
                        else //Right
                        {
                            meleeAttack.transform.position = transform.position + new Vector3(3, 0, 0);
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
}

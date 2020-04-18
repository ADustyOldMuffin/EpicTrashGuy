using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDirection : MonoBehaviour
{
    private Vector2 _direction;
    private Vector3 _mousePos;

    private Camera _cam;
    
    void Awake()
    {
        _cam = Camera.main;
    }

    void Update()
    {
        _mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        _direction = (_mousePos - transform.position).normalized;
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class MainMenuDolly : MonoBehaviour
{
    private CinemachineVirtualCamera _virtualCamera;
    private CinemachineTrackedDolly _dolly;

    public float speed = .5f;

    private void Awake()
    {
        _virtualCamera = GetComponent<CinemachineVirtualCamera>();
        _dolly = _virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        _dolly.m_PathPosition += Time.fixedDeltaTime * speed;
    }
}

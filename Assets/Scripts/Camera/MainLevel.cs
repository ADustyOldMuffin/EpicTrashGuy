using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class MainLevel : MonoBehaviour
{
    private CinemachineVirtualCamera _virtualCamera;

    private CinemachineTrackedDolly _trackedDolly;

    public float moveSpeed;
    public int position = 0;
    private int currentPosition = 0;
    

    private void Awake()
    {
        _virtualCamera = GetComponentInParent<CinemachineVirtualCamera>();
        _trackedDolly = _virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    private void FixedUpdate()
    {
        if (position > currentPosition)
        {
            _trackedDolly.m_PathPosition += Time.fixedDeltaTime * moveSpeed;

            if (_trackedDolly.m_PathPosition >= position)
                currentPosition = position;
        }
        else if(position < currentPosition)
        {
            _trackedDolly.m_PathPosition -= Time.fixedDeltaTime * moveSpeed;

            if (_trackedDolly.m_PathPosition <= position)
                currentPosition = position;
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            position = 1;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            position = 0;
    }
}

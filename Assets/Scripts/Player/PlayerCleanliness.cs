using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCleanliness : MonoBehaviour
{
    public float maxCleanliness = 100;
    public float currentCleanliness = 0;

    public HealthBar HealthBar;

    private void Awake()
    {
        currentCleanliness = maxCleanliness;
        FindObjectOfType<Game>().SetHealth(this);
    }

    // Update is called once per frame
    void Update()
    {
        var countOfTrash = GameObject.FindGameObjectsWithTag("Trash").Length;
        currentCleanliness = maxCleanliness - countOfTrash;
        HealthBar.SetHealth((int)currentCleanliness);
    }
}

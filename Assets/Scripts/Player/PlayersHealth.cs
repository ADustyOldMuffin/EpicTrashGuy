using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersHealth : BaseHealthSystem
{
    [SerializeField] private ShowPlayerHealth showPlayerHealth;

    private void Start()
    {
        showPlayerHealth.HealthSetup(maxHealth);
    }
}

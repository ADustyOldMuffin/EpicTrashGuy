using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemies : MonoBehaviour
{
    [SerializeField] private int damage = 2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var target = other.gameObject;

        ITakeDamage canDamage = target.GetComponent<ITakeDamage>();
        canDamage?.Damage(damage);
    }
}

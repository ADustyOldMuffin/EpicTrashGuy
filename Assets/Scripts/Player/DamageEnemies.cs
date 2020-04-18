using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemies : MonoBehaviour
{
    [SerializeField] private int damage = 2;
    [SerializeField] private string damageToTag;
    [SerializeField] private bool destroyOnHit = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag(damageToTag))
        {
            return;
        }

        var target = other.gameObject;

        ITakeDamage canDamage = target.GetComponent<ITakeDamage>();
        canDamage?.Damage(damage);
        
        if(destroyOnHit)
            Destroy(gameObject);
    }
}

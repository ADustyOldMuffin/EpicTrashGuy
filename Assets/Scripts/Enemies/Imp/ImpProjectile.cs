using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpProjectile : MonoBehaviour
{
    public float damage;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponentInParent<Hittable>().ObjectHit((int)damage);
        }
        
        if(!other.gameObject.CompareTag("Hittable"))
            Destroy(gameObject);
    }
}

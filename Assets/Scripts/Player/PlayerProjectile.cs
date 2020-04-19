using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float damage;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Hittable"))
        {
            other.gameObject.GetComponentInParent<Hittable>().ObjectHit((int)damage);
        }
        
        if(!other.gameObject.CompareTag("Player"))
            Destroy(gameObject);
    }
}

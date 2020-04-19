using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public int damage = 20;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hittable"))
        {
            other.gameObject.GetComponentInParent<Hittable>().ObjectHit(damage);
        }
    }
}

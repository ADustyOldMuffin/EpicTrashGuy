using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("damaging"))
        {
            //TODO This should cause damage.
            Destroy(other.gameObject);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClean : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Trash"))
        {
            Destroy(other.gameObject);
        }
    }
}

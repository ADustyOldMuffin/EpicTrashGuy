using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float speed = 8;
    [SerializeField] private float lifetime = 10;
    
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        _rb.velocity = transform.up * speed;

        lifetime -= Time.fixedDeltaTime;
        
        if(lifetime <= 0)
            Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    public float travelTime;
    public Vector3 target;

    public int Damage = 1;
    
    
    private void FixedUpdate()
    {
        //transform.position = Vector2.MoveTowards(transform.position, Vector2.up, moveSpeed * Time.deltaTime);
        GetComponent<Rigidbody2D>().velocity = transform.up * (Time.fixedDeltaTime * moveSpeed);
        travelTime -= Time.deltaTime;
        
        if(travelTime <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var target = other.gameObject;

        if (!target.CompareTag("Enemies"))
        {
            ITakeDamage canDamage = target.GetComponent<ITakeDamage>();
            canDamage?.Damage(Damage);
            
            Destroy(gameObject);
        }
    }
}

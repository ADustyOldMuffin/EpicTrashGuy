using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    public float travelTime;
    public Vector3 target;

    // Update is called once per frame
    private void FixedUpdate()
    {
        //transform.position = Vector2.MoveTowards(transform.position, Vector2.up, moveSpeed * Time.deltaTime);
        GetComponent<Rigidbody2D>().velocity = transform.up * (Time.fixedDeltaTime * moveSpeed);
        travelTime -= Time.deltaTime;
        
        if(travelTime <= 0)
            Destroy(gameObject);
    }
}

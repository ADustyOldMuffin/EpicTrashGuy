using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Hittable))]
[RequireComponent(typeof(BaseHealthSystem))]
public class PlayerHittable : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Hittable>().objectWasHit += OnPlayerHit;
    }

    private void OnPlayerHit(object sender, Hittable.ObjectHitArgs args)
    {
        GetComponent<BaseHealthSystem>().Damage(args.Damage);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hittable : MonoBehaviour
{

    public EventHandler<ObjectHitArgs> objectWasHit;

    public void ObjectHit(int damage)
    {
        objectWasHit.Invoke(this, new ObjectHitArgs(){ Damage = damage});
    }

    public class ObjectHitArgs : EventArgs {
        public int Damage { get; set; }
    }
}

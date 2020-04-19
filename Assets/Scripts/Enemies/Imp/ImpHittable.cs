using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Hittable))]
[RequireComponent(typeof(BaseHealthSystem))]
public class ImpHittable : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Hittable>().objectWasHit += OnImpHit;
    }

    private void OnImpHit(object sender, Hittable.ObjectHitArgs args)
    {
        GetComponent<BaseHealthSystem>().Damage(args.Damage);
    }
}

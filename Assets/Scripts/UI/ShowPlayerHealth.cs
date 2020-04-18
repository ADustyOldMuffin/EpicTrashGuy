using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject UIHeart;

    [SerializeField] private float wide = 25, yPlacement = -10;
    
    

    public void HealthSetup(int maxHealth)
    {
        for (int i = 0; i < maxHealth; i++)
        {
            Vector3 pos = new Vector3(wide * i + wide / 2, yPlacement, 0) + transform.position;
            var spawn = Instantiate(UIHeart, pos, Quaternion.identity);
            spawn.transform.SetParent(transform);
        }
    }
}

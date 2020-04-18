using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject UIHeart;

    [SerializeField] private float wide = 25;
    
    
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector3 pos = new Vector3(wide * i + wide / 2, -wide / 2, 0) + transform.position;
            var spawn = Instantiate(UIHeart, pos, Quaternion.identity);
            spawn.transform.SetParent(transform);
        }
    }
}

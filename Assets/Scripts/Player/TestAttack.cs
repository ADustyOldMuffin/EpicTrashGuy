using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAttack : MonoBehaviour
{
    [SerializeField] private GameObject attack;
    [SerializeField] private KeyCode attackKey = KeyCode.Space;
    [SerializeField] private float attackTime = .1f;
    
    void Start()
    {
        attack.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(attackKey))
        {
            StartCoroutine(MakeAttack());
        }
    }

    IEnumerator MakeAttack()
    {
        attack.SetActive(true);
        yield return new WaitForSeconds(attackTime);
        attack.SetActive(false);
    }
}

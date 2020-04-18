using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPlayersAttackState : MonoBehaviour
{
     [SerializeField] private GameObject rangeSymbol, meleeSymbol;


     public void ChangeStateSprite(PlayersAttackStat changeToWhat)
     {
         if (changeToWhat == PlayersAttackStat.range)
         {
             rangeSymbol.SetActive(true);
             meleeSymbol.SetActive(false);
         }

         if (changeToWhat == PlayersAttackStat.melee)
         {
             meleeSymbol.SetActive(true);
             rangeSymbol.SetActive(false);
         }
     }
}

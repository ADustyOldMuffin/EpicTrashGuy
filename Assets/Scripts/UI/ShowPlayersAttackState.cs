using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPlayersAttackState : MonoBehaviour
{
     [SerializeField] private GameObject rangeSymbol, meleeSymbol;


     public void ChangeStateSprite(PlayersAttackStat changeToWhat)
     {
         if (changeToWhat == PlayersAttackStat.melee)
         {
             rangeSymbol.SetActive(true);
             meleeSymbol.SetActive(false);
         }

         if (changeToWhat == PlayersAttackStat.range)
         {
             meleeSymbol.SetActive(true);
             rangeSymbol.SetActive(false);
         }
     }
}

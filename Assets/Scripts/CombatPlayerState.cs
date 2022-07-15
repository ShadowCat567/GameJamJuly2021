using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPlayerState : CombatBaseState
{
    public override void EnterState(GameObject enemy, Player player, CombatManager cm)
    {
        cm.playerTurn.SetActive(true);
    }

    public override void UpdateState(GameObject enemy, Player player, CombatManager cm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cm.ChangeState(cm.enemyAttack);
        }
    }

    public override void ExitState(GameObject enemy, Player player, CombatManager cm)
    {
        cm.playerTurn.SetActive(false);
    }
}

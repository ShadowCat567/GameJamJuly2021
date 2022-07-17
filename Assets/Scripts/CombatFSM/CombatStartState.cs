using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStartState : CombatBaseState
{
    public override void EnterState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.startingTurn.SetActive(true);

        cm.startingTxt.text = "Try me! You won't make it to your friend! \n ['V'] to attack or ['B'] to block";
    }

    public override void UpdateState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            cm.blocking = true;
            cm.ChangeState(cm.playerAttack);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            cm.ChangeState(cm.playerAttack);
        }
    }

    public override void ExitState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.startingTurn.SetActive(false);
        cm.EnemyHealth.SetActive(true);
    }
}

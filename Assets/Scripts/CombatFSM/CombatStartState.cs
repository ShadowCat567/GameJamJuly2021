using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStartState : CombatBaseState
{
    public override void EnterState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.startingTurn.SetActive(true);
    }

    public override void UpdateState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        string displayText = "Press 'B' to block or 'V' to attack";

        cm.startingTxt.text = displayText;

        if (Input.GetKeyDown(KeyCode.B))
        {
            cm.ChangeState(cm.playerAttack);
            cm.blocking = true;
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

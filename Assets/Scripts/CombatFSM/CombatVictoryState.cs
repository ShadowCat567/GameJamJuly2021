using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatVictoryState : CombatBaseState
{
    public override void EnterState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.victoryTurn.SetActive(true);

        cm.victoryTxt.text = "You successfully defeated the Weevil! \nPress SPACE to continue";
    }

    public override void UpdateState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cm.EnemyHealth.SetActive(false);
            cm.combatPanel.SetActive(false);
        }
    }

    public override void ExitState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.victoryTurn.SetActive(false);
    }
}

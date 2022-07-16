using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatVictoryState : CombatBaseState
{
    public override void EnterState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.victoryTurn.SetActive(true);
    }

    public override void UpdateState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        string displayText = "You successfully defeated the enemy! \nPress SPACE to continue";

        cm.victoryTxt.text = displayText;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            cm.combatPanel.SetActive(false);
        }
    }

    public override void ExitState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.victoryTurn.SetActive(false);
        cm.EnemyHealth.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatVictoryState : CombatBaseState
{
    public override void EnterState(GameObject enemy, Player player, CombatManager cm)
    {
        cm.victoryTurn.SetActive(true);
    }

    public override void UpdateState(GameObject enemy, Player player, CombatManager cm)
    {

    }

    public override void ExitState(GameObject enemy, Player player, CombatManager cm)
    {
        cm.victoryTurn.SetActive(false);
    }
}

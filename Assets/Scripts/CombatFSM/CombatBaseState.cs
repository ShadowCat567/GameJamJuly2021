using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CombatBaseState
{
    public abstract void EnterState(EnemyBehavior enemy, Player player, CombatManager cm);
    public abstract void UpdateState(EnemyBehavior enemy, Player player, CombatManager cm);
    public abstract void ExitState(EnemyBehavior enemy, Player player, CombatManager cm);
}

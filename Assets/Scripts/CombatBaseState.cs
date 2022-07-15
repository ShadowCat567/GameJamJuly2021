using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CombatBaseState
{
    public abstract void EnterState(GameObject enemy, Player player, CombatManager cm);
    public abstract void UpdateState(GameObject enemy, Player player, CombatManager cm);
    public abstract void ExitState(GameObject enemy, Player player, CombatManager cm);
}

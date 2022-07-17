using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FightBaseState 
{
    public abstract void EnterState(FinalBoss boss, Player player, BossFightManager bfm);
    public abstract void UpdateState(FinalBoss boss, Player player, BossFightManager bfm);
    public abstract void ExitState(FinalBoss boss, Player player, BossFightManager bfm);
}

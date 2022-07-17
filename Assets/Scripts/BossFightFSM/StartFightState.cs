using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFightState : FightBaseState
{
    public override void EnterState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        bfm.startAction.SetActive(true);
        bfm.startTxt.text = "You are not strong enough to defeat me, Ladybug! \n ['V'] to Attack or ['B'] to Block";
    }

    public override void UpdateState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            bfm.soundSource.PlayOneShot(bfm.next);
            bfm.ChangeState(bfm.playerActionState);
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            bfm.soundSource.PlayOneShot(bfm.next);
            bfm.playerBlocking = true;
            bfm.ChangeState(bfm.playerActionState);
        }
    }

    public override void ExitState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        bfm.BossHealth.SetActive(true);
        bfm.startAction.SetActive(false);
    }
}

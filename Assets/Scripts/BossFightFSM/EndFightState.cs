using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFightState : FightBaseState
{
    public override void EnterState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        bfm.victoryAction.SetActive(true);
        bfm.victoryTxt.text = "You have defeated the Final Boss! \n   [SPACE]";
        player.Heal(13);
    }

    public override void UpdateState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            bfm.soundSource.PlayOneShot(bfm.next);
            bfm.BossHealth.SetActive(false);
            bfm.fightPanel.SetActive(false);
        }
    }

    public override void ExitState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        bfm.victoryAction.SetActive(true);
    }
}

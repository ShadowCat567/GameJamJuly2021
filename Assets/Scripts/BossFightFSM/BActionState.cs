using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BActionState : FightBaseState
{
    public override void EnterState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        bfm.bossAction.SetActive(true);

        if(bfm.playerBlocking)
        {
            int damageTaken = boss.DmgMod + boss.GenerateAttackValue();

            if(player.defenseStat < damageTaken)
            {
                player.TakeDamage(damageTaken - player.defenseStat);
                bfm.bossTxt.text = damageTaken - player.defenseStat + " has been dealt to you. \nPress 'V' to attack or 'B' to block";
            }

            else
            {
                bfm.bossTxt.text = "You successfully blocked the Boss's attack! \nPress 'V' to attack or 'B' to block";
            }
        }

        else
        {
            int isBlocking = boss.Blocking();

            if (isBlocking == 0)
            {
                bfm.bossTxt.text = "The Boss blocked. You do not take damage. \nPress 'V' to attack or 'B' to block";
            }

            else
            {
                player.TakeDamage(boss.DmgMod + boss.GenerateAttackValue());
                bfm.bossTxt.text = boss.DmgMod + boss.GenerateAttackValue() + " has been dealt to you. \nPress 'V' to attack or 'B' to block";
            }
        }
    }

    public override void UpdateState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            bfm.playerBlocking = false;
            bfm.ChangeState(bfm.playerActionState);
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            bfm.playerBlocking = true;
            bfm.ChangeState(bfm.playerActionState);
        }
    }

    public override void ExitState(FinalBoss boss, Player player, BossFightManager bfm)
    {
        bfm.bossAction.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPlayerState : CombatBaseState
{
    public override void EnterState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.playerTurn.SetActive(true);

        if (cm.blocking)
        {
            cm.playerTurnTxt.text = "You will block the next incoming attack \nPress SPACE to continue.";
        }

        else
        {
            int playerDmgDealt = player.attackStat + player.GenerateAttackValue();
            enemy.TakeDamage(playerDmgDealt);
            cm.playerTurnTxt.text = "You dealt " + playerDmgDealt + " damage! \nPress SPACE to continue.";
        }
    }

    public override void UpdateState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (enemy.curEnemyHealth <= 0)
            {
                cm.ChangeState(cm.victoryState);
            }
            else
            {
                cm.ChangeState(cm.enemyAttack);
            }
        }
    }

    public override void ExitState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.playerTurn.SetActive(false);
    }
}

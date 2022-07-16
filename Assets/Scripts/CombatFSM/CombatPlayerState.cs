using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPlayerState : CombatBaseState
{
    public override void EnterState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.playerTurn.SetActive(true);
        player.generateAttackVal = true;
        enemy.dmgTaken = true;
    }

    public override void UpdateState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        string displayTxt;

        if(cm.blocking)
        {
            displayTxt = "You will block the next incoming attack \nPress SPACE to continue.";
        }

        else
        {
            int playerDmgDealt = player.attackStat + player.GenerateAttackValue();
            enemy.TakeDamage(playerDmgDealt);
            displayTxt = "You dealt " + playerDmgDealt + " damage! \nPress SPACE to continue.";
        }

        cm.playerTurnTxt.text = displayTxt;

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

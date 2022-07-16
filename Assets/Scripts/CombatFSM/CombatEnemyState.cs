using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEnemyState : CombatBaseState
{
    public override void EnterState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.enemyTurn.SetActive(true);
        enemy.genAttkVal = true;
        player.takenDamage = true;
    }

    public override void UpdateState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        string displayTxt;
        int dmg = enemy.enemyDamageMod + enemy.GenerateAttackValue();

        if(cm.blocking)
        {
            if(player.defenseStat < dmg)
            {
                int damageTaken = player.defenseStat - dmg;
                player.TakeDamage(damageTaken);
                displayTxt = damageTaken + " damage has been dealt to you. \nPress 'B' to block or 'V' to attack";
            }

            else
            {
                displayTxt = "You sucessfully blocked the enemy's attack! \nPress 'B' to block or 'V' to attack";
            }
        }

        else
        {
            player.TakeDamage(dmg);
            displayTxt = dmg + " damage has been dealt to you. \nPress 'B' to block or 'V' to attack";
        }

        cm.enemyTurnTxt.text = displayTxt;
        cm.blocking = false;

        if (Input.GetKeyDown(KeyCode.B))
        {
            cm.ChangeState(cm.playerAttack);
            cm.blocking = true;
        }
        
        if(Input.GetKeyDown(KeyCode.V))
        {
            cm.ChangeState(cm.playerAttack);
        }
    }

    public override void ExitState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.enemyTurn.SetActive(false);
    }
}

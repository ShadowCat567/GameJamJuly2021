using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEnemyState : CombatBaseState
{
    public override void EnterState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.enemyTurn.SetActive(true);

        if (cm.blocking)
        {
            int damageTaken = (enemy.enemyDamageMod + enemy.GenerateAttackValue()) - player.defenseStat;
            if (damageTaken > 0)
            {
                player.TakeDamage(damageTaken);
                cm.enemyTurnTxt.text = damageTaken + " damage has been dealt to you. \n ['V'] to attack or ['B'] to block";
            }

            else if (damageTaken <= 0)
            {
                cm.enemyTurnTxt.text = "You sucessfully blocked the Weevil's attack! \n ['V'] to attack or ['B'] to block";
            }
        }

        else
        {
            player.TakeDamage(enemy.enemyDamageMod + enemy.GenerateAttackValue());
            cm.enemyTurnTxt.text = enemy.enemyDamageMod + enemy.GenerateAttackValue() + " damage has been dealt to you. \nPress 'V' to attack or 'B' to block";
        }
    }

    public override void UpdateState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            cm.blocking = true;
            cm.ChangeState(cm.playerAttack);
        }
        
        if(Input.GetKeyDown(KeyCode.V))
        {
            cm.blocking = false;
            cm.ChangeState(cm.playerAttack);
        }
    }

    public override void ExitState(EnemyBehavior enemy, Player player, CombatManager cm)
    {
        cm.enemyTurn.SetActive(false);
    }
}
